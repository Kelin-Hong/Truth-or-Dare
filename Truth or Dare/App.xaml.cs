using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace mangoBgAnimation
{
    public partial class App : Application
    {
        /// <summary>
        /// Provides easy access to the root frame of the Phone Application.
        /// </summary>
        /// <returns>The root frame of the Phone Application.</returns>
        public PhoneApplicationFrame RootFrame { get; private set; }

        /// <summary>
        /// Constructor for the Application object.
        /// </summary>
        public App()
        {
            // Global handler for uncaught exceptions. 
            UnhandledException += Application_UnhandledException;

            // Standard Silverlight initialization
            InitializeComponent();

            // Phone-specific initialization
            InitializePhoneApplication();

            // Show graphics profiling information while debugging.
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // Display the current frame rate counters.
                Application.Current.Host.Settings.EnableFrameRateCounter = true;

                // Show the areas of the app that are being redrawn in each frame.
                //Application.Current.Host.Settings.EnableRedrawRegions = true;

                // Enable non-production analysis visualization mode, 
                // which shows areas of a page that are handed off to GPU with a colored overlay.
                //Application.Current.Host.Settings.EnableCacheVisualization = true;

                // Disable the application idle detection by setting the UserIdleDetectionMode property of the
                // application's PhoneApplicationService object to Disabled.
                // Caution:- Use this under debug mode only. Application that disables user idle detection will continue to run
                // and consume battery power when the user is not using the phone.
                PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled;
            }

        }

        // Code to execute when the application is launching (eg, from Start)
        // This code will not execute when the application is reactivated
        private void Application_Launching(object sender, LaunchingEventArgs e)
        {
            using (DataBase db = new DataBase(DataBase.contectString))
            {
                if (!db.DatabaseExists())
                {
                    db.CreateDatabase();
                    List<Table2> list2 = new List<Table2>
                  {

                    new Table2{ IsUse=true,Title="大冒险",Content="请在现场选一位异性同学，向他或她表白"},
               
          
                   
                     new Table2{ IsUse=true,Title="大冒险",Content="站到凳子上表演大猩猩捶胸呐喊动作 "},
                     new Table2{ IsUse=true,Title="大冒险",Content="学超级名模走秀，绕桌子或教室一圈 "},
                     new Table2{ IsUse=true,Title="大冒险",Content="与本桌或本教室离你最近的一位异性同学拥抱十秒钟。 "},
                     new Table2{ IsUse=true,Title="大冒险",Content="和坐你右边的同学深情对视并对她或他唱《老鼠爱大米》中的高潮部分"},
                     new Table2{ IsUse=true,Title="大冒险",Content="和离你最近的一位同性同学十指相扣10秒，并看着对方说眼睛含情脉脉地说：我爱你。 "},
                     new Table2{ IsUse=true,Title="大冒险",Content="对在场的一位异性说一分钟情话，不要冷场哦。（邀请） "},
                    new Table2{ IsUse=true,Title="大冒险",Content="蹲凳子上上做便秘状10秒钟 "},
               
                    new Table2{ IsUse=true,Title="大冒险",Content="冲到门外撕心裂肺的喊“台湾回归啦！台湾回归啦！大家快看中央一台……”（跟真有那么回事似的） "},
                    new Table2{ IsUse=true,Title="大冒险",Content="用异性的声音唱一首大家都比较熟悉的歌 "},

                    new Table2{ IsUse=true,Title="大冒险",Content="将舌头翻过来，舌面朝下，舌底朝上 "},
                    new Table2{ IsUse=true,Title="大冒险",Content="桌子上放一本书(或者其他东西，比如瓶盖)，厚约5cm，长宽约5cm×5cm，前面放一1角硬币，用嘴巴将硬币吹到书上 "},
                    new Table2{ IsUse=true,Title="大冒险",Content="重温大话西游的经典对白，现场满意为止 "},
                    new Table2{ IsUse=true,Title="大冒险",Content="（对男生）请展示自己最性感的动作和最妩媚的动作 "},
                    new Table2{ IsUse=true,Title="大冒险",Content=" 对窗外大喊“我好寂寞啊”； "},
                    new Table2{ IsUse=true,Title="大冒险",Content="慢慢地性感地 把上衣撩起到不能再撩起的位置；"},
                    new Table2{ IsUse=true,Title="大冒险",Content="露出肚皮，扭腰扭屁股，各扭3圈；"},
                    new Table2{ IsUse=true,Title="大冒险",Content=" 穿自己的外套表演 张倾城之“我脱、我穿、我再脱、我再穿”；"},
                    new Table2{ IsUse=true,Title="大冒险",Content="学水兵月做动作，然后对一个人說: 我要代替月亮懲罰你!! "},
                    new Table2{ IsUse=true,Title="大冒险",Content="两人面对面作搓澡状，屁股还要一扭一扭的，还要唱“洗刷刷，洗刷刷”"},
                    new Table2{ IsUse=true,Title="大冒险",Content="让一个女的想办法让某男兴奋起来； "},
                    new Table2{ IsUse=true,Title="大冒险",Content="情景剧：一男一女相遇，男生说：你好，我姓锄名禾，你呢？女生说：“我名叫当午。”男生女生同时说：哦！原来是锄禾日当午啊！ "},
                    new Table2{ IsUse=true,Title="大冒险",Content="正面对着十指 交扣，深情对视，深情朗诵骆宾王的《鹅》 "},
                    new Table2{ IsUse=true,Title="大冒险",Content="男生摸自 己胸说“唉太小了”；"},
                    new Table2{ IsUse=true,Title="大冒险",Content="摆3个芙蓉姐姐S形；"},
                    new Table2{ IsUse=true,Title="大冒险",Content="抓着铁门喊“放我出去！"},
                    new Table2{ IsUse=true,Title="大冒险",Content="神情的吻墙10秒 "},
                    new Table2{ IsUse=true,Title="大冒险",Content="唱青藏高原最后一句 "},

                    new Table2{ IsUse=true,Title="大冒险",Content="选一个男生 一边捶他的胸一边说： 你好讨厌哦 "},
                    new Table2{ IsUse=true,Title="大冒险",Content="男生仰躺地上，女生撑在上面，坚持5秒钟； "},
                    new Table2{ IsUse=true,Title="大冒险",Content="选一个女 生说 ：我将把你紧紧 地搂在怀中，吻你亿万次，像在赤道上面那样炽烈的吻。（拿破仑致约瑟芬） "},
                    new Table2{ IsUse=true,Title="大冒险",Content="大喊 燃烧吧，小宇宙～ "},
                    new Table2{ IsUse=true,Title="大冒险",Content="做自己最性感、最妩媚的表情或动作 "},
                    new Table2{ IsUse=true,Title="大冒险",Content="在附近找一个最大的石头，并抱着它深情的说：兄弟，我找了你好久了…… "},
                    new Table2{ IsUse=true,Title="大冒险",Content="拿上一个被惩罚的人的手机打电话，由你来说出第几个并打出电话，打通后你说：我暗恋你好久啦……      "},


                     new Table2{ IsUse=true,Title="大冒险",Content="在走廊里拽住见到的第一个人，大声喊：“我是猪，我是猪，我真的是猪！” "},
                    new Table2{ IsUse=true,Title="大冒险",Content="如果是男生，大声喊：“我爱芙蓉姐姐！”；如果是女生，大喊，“谁动了我的蛤蟆？”"},
                    new Table2{ IsUse=true,Title="大冒险",Content="详细描述你的初吻的全经过，如果没有就说想象中的"},
                    new Table2{ IsUse=true,Title="大冒险",Content="对在场的一位异性连续不断表白三分钟（PS：必须超过100字）"},
                    new Table2{ IsUse=true,Title="大冒险",Content="邀请一位异性和自己一起一边做动作一边唱“我爱洗澡皮肤好好”"},
                    new Table2{ IsUse=true,Title="大冒险",Content="表演古代特殊工作者在街头拉客 "},
                  
                  }; 
                    db.table2.InsertAllOnSubmit(list2);
                    List<Table1> list1 = new List<Table1>
                   {
                    new Table1{ IsUse=true,Title="真心话",Content="今天穿什么颜色的内裤?"},
                    new Table1{ IsUse=true,Title="真心话",Content="你如果洗澡洗一半全身都是泡的时候停水了，怎么办？?"},
                    new Table1{ IsUse=true,Title="真心话",Content="在现场所有同学中，你看哪位异性同学最舒服？ "},
                    new Table1{ IsUse=true,Title="真心话",Content="你最怕的事情或东西是什么（说出三件）。 "},
                   
                    new Table1{ IsUse=true,Title="真心话",Content="你通常用那只指头挖鼻子？ "},
         
                    new Table1{ IsUse=true,Title="真心话",Content="你在意你的老婆（老公）不是处女（处男）吗？ "},
                    new Table1{ IsUse=true,Title="真心话",Content="你作弊使用过的最高招（呵呵，可能有的人是从来不作弊的，所以……大家提提意见）"},
                    new Table1{ IsUse=true,Title="真心话",Content="如果让你从现场找一位gg/mm的话，你会选择谁？给出三个理由。"},
                    new Table1{ IsUse=true,Title="真心话",Content="最欣赏自己哪个部位？对自己那个部位最不满意？"},
                    new Table1{ IsUse=true,Title="真心话",Content="你的仇人在上厕所时，没纸出不来，你怎么办？ "},
                    new Table1{ IsUse=true,Title="真心话",Content="在澡堂洗澡的时候碰见同性恋，你最想干什么?"},
                    new Table1{ IsUse=true,Title="真心话",Content="你被人甩过吗?又是怎么度过的呢??"},
                    new Table1{ IsUse=true,Title="真心话",Content="你袜子最长的一次是隔多长时间洗的？？是最长！"},
                    new Table1{ IsUse=true,Title="真心话",Content="闻过最臭的东西是什么？"},
                    new Table1{ IsUse=true,Title="真心话",Content="喜欢一个人，会怎么接近他（她）？（PS：一定要接近！）"},
                    new Table1{ IsUse=true,Title="真心话",Content=".最囧的一件事"},
                    new Table1{ IsUse=true,Title="真心话",Content="男朋友/女朋友那个重要（这个是不是有点损……） ?"},
                    new Table1{ IsUse=true,Title="真心话",Content=".自己最丢人的事 "},
                    new Table1{ IsUse=true,Title="真心话",Content="到目前为止你做过最疯狂的事是？ "},
                    new Table1{ IsUse=true,Title="真心话",Content="在街上偶遇心爱的人，并开始一段气氛很好的对话，可是突然内急，你会怎么做？"},
                    new Table1{ IsUse=true,Title="真心话",Content="你心目中理想的爱人是什么样子呢？ "},
                    new Table1{ IsUse=true,Title="真心话",Content="初吻年龄 "},
                    new Table1{ IsUse=true,Title="真心话",Content="身上哪个部位最敏感 "},
                    new Table1{ IsUse=true,Title="真心话",Content="在你眼里，我是个怎样的人？我要听实话啦…… "},
                    new Table1{ IsUse=true,Title="真心话",Content="如果有一天我对你说我爱上你了，你怎么办"},
                    new Table1{ IsUse=true,Title="真心话",Content="怎样看待性"},
                    new Table1{ IsUse=true,Title="真心话",Content="如何向喜欢的人表白？ "},
                    new Table1{ IsUse=true,Title="真心话",Content="知道几种make love的姿势？"},
              
                   

                    new Table1{ IsUse=true,Title="真心话",Content="你最后一次上WC是什么时候 用了多少纸？"},
                    new Table1{ IsUse=true,Title="真心话",Content="上厕所没带纸，等多久都没人来，怎么办？ "},
                    new Table1{ IsUse=true,Title="真心话",Content="初吻年龄 "},
                    new Table1{ IsUse=true,Title="真心话",Content="身上哪个部位最敏感 "},
                    new Table1{ IsUse=true,Title="真心话",Content="在你眼里，我是个怎样的人？我要听实话啦…… "},
                    new Table1{ IsUse=true,Title="真心话",Content="如果有一天我对你说我爱上你了，你怎么办"},
                    new Table1{ IsUse=true,Title="真心话",Content="怎样看待性"},
                    new Table1{ IsUse=true,Title="真心话",Content="如何向喜欢的人表白？ "},
                    new Table1{ IsUse=true,Title="真心话",Content="知道几种make love的姿势？"},
                   };
                    db.table1.InsertAllOnSubmit(list1);
                    db.SubmitChanges();
                }
       
            }
           
        }

        // Code to execute when the application is activated (brought to foreground)
        // This code will not execute when the application is first launched
        private void Application_Activated(object sender, ActivatedEventArgs e)
        {
        }

        // Code to execute when the application is deactivated (sent to background)
        // This code will not execute when the application is closing
        private void Application_Deactivated(object sender, DeactivatedEventArgs e)
        {
        }

        // Code to execute when the application is closing (eg, user hit Back)
        // This code will not execute when the application is deactivated
        private void Application_Closing(object sender, ClosingEventArgs e)
        {
        }

        // Code to execute if a navigation fails
        private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // A navigation has failed; break into the debugger
                System.Diagnostics.Debugger.Break();
            }
        }

        // Code to execute on Unhandled Exceptions
        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                // An unhandled exception has occurred; break into the debugger
                System.Diagnostics.Debugger.Break();
            }
        }

        #region Phone application initialization

        // Avoid double-initialization
        private bool phoneApplicationInitialized = false;

        // Do not add any additional code to this method
        private void InitializePhoneApplication()
        {
            if (phoneApplicationInitialized)
                return;

            // Create the frame but don't set it as RootVisual yet; this allows the splash
            // screen to remain active until the application is ready to render.
            RootFrame = new TransitionFrame();
            RootFrame.Navigated += CompleteInitializePhoneApplication;

            // Handle navigation failures
            RootFrame.NavigationFailed += RootFrame_NavigationFailed;

            // Ensure we don't initialize again
            phoneApplicationInitialized = true;
        }

        // Do not add any additional code to this method
        private void CompleteInitializePhoneApplication(object sender, NavigationEventArgs e)
        {
            // Set the root visual to allow the application to render
            if (RootVisual != RootFrame)
                RootVisual = RootFrame;

            // Remove this handler since it is no longer needed
            RootFrame.Navigated -= CompleteInitializePhoneApplication;
        }

        #endregion
    }
}