namespace GoogleARCore.Examples.AugmentedImage
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using UnityEngine;
    using GoogleARCore;
    using UnityEngine.UI;

    public class ShootScript : MonoBehaviour
    {
        
        [SerializeField] GameObject applePrefab;
        private BombController appleScript;

        private bool mode = true;

        private int buildNum;

        public Text text;

        private List<AugmentedImage> m_TempAugmentedImages = new List<AugmentedImage>();

        // Use this for initialization
        void Start()
        {
            appleScript = applePrefab.GetComponent<BombController>();
            buildNum = 0;
        }

        // Update is called once per frame
        void Update()
        {
            //escキーで脱出
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }


            if (Session.Status != SessionStatus.Tracking)
            {
                return;
            }

            //マーカーの処理----------------------------------------------------------------------------------------
            // Get updated augmented images for this frame.
            Session.GetTrackables<AugmentedImage>(m_TempAugmentedImages, TrackableQueryFilter.Updated);

            // Create visualizers and anchors for updated augmented images that are tracking and do not previously
            // have a visualizer. Remove visualizers for stopped images.
            foreach (var image in m_TempAugmentedImages)//マーカー画像テーブルについてforeach
            {
                if (image.TrackingState == TrackingState.Tracking)
                {
                    buildNum = int.Parse(image.Name);
                    text.text = image.Name;//デバッグ用

                }
            }
            //-----------------------------------------------------------------------------------------------------

            //打つ処理----------------------------------------------------------------------------------------------
            Touch touch;
            if (Input.touchCount < 1 ||
                (touch = Input.GetTouch(0)).phase != TouchPhase.Began)
            {
                //画面に触れていないorすでに触れているなら何もしない
                return;
            }

            if(Input.GetButtonDown("Canvas/normalUI/crackButton") || Input.GetButtonDown("Canvas/normalUI/fireButton") || Input.GetButtonDown("Canvas/normalUI/Pause")){
                return;
            }


            //タップした座標にドロイド君を移動
            TrackableHit hit;
            TrackableHitFlags filter = TrackableHitFlags.PlaneWithinPolygon;
            if (Frame.Raycast(touch.position.x, touch.position.y, filter, out hit))
            {
                //平面にヒット＆裏面でなければドロイド君を置く
                if ((hit.Trackable is DetectedPlane) &&
                   Vector3.Dot(Camera.main.transform.position - hit.Pose.position, hit.Pose.rotation * Vector3.up) > 0)
                {
                    //Anchorを設定
                    var anchor = hit.Trackable.CreateAnchor(hit.Pose);
                    //apple投げる(位置気になる)
                    GameObject apple = Instantiate(applePrefab) as GameObject;
                    apple.transform.position = Camera.main.transform.TransformPoint(0, 0, 0.5f);
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    Vector3 worldDir = ray.direction;
                    apple.GetComponent<Rigidbody>().AddForce(worldDir.normalized * 100, ForceMode.Impulse);
                    apple.transform.parent = anchor.transform;

                }
            }
        }
        //-------------------------------------------------------------------------------------------------------------

        //Appleprefab更新用のfixedUpdate---------------------------------------------------------------------------------
        private void FixedUpdate()
        {
            appleScript.n = getParticleNum(buildNum);
            appleScript.mode = mode;
        }
        //-------------------------------------------------------------------------------------------------------------

        //マーカー画像名から該当パーティクルを出力----------------------------------------------------------------------------
        //一つの建物につき１０枚ほどのマーカー画像：増やしても良い
        private int getParticleNum(int markerNum){
            if(markerNum > 0 && markerNum <= 10){
                return 1;
            }
            else if(markerNum > 10){
                return 2;
            }
            return 0;
        }
        //------------------------------------------------------------------------------------------------------------

        //ボタンによるモード変更------------------------------------------------------------------------------------------
        public void crackButtonDown(){
            mode = false;
        }

        public void fireButtonDown(){
            mode = true;
        }
        //-------------------------------------------------------------------------------------------------------------
    }
}

