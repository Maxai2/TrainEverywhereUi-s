using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TrainEverywhere
{
    public partial class App : Application
    {
        public static int ScreenWidth;
        public static int ScreenHeight;

        public static TabbedPage tabbedPage = new TabbedPage();

        static public ObservableCollection<Exercise> MondayExer = new ObservableCollection<Exercise>()
        {
            new Exercise
            {
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2018/02/Incline-dumbbell-fly-990x710.png",
                ExerciseDescription = "Holding a dumbbell in each hand, sit on a bench inclined at 45 degrees and rest each dumbbell on a knee. Lie backward, and as you do so, kick the dumbbells up into position over your chest, one at a time. Spread your legs and plant your feet flat on the floor. Flex your elbows slightly, and internally rotate your shoulders so that your elbows point out to the sides. Keeping your elbows locked, inhale as you lower the dumbbells to your sides in an arcing motion until you feel a mild stretch in your chest or shoulders. Exhale as you reverse the motion and press the dumbbells back up to the starting position. Repeat for the prescribed number of repetitions.",
                ExerciseName = "Incline dumbbell fly"
            },
            new Exercise
            {
                ExerciseName = "Svend press",
                ExerciseDescription = "Squeeze a weight plate between your palms. Raise it to your chest, with your fingers pointing forward.Pull your shoulders back and stick out your chest. Raise your elbows so that your arms are parallel with the floor. Exhale as you slowly extend your elbows and push the plate out in front of you. Hold for a count of two and squeeze your chest muscles. Inhale as you slowly pull the plate back in to your chest. Repeat.",
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2016/12/Svend-Press-990x914.png"
            },
            new Exercise
            {
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2016/12/machine-chest-press-990x698.png",
                ExerciseDescription = "Adjust the seat so that the handles are approximately chest height.Sit in the chest press machine with your back pressed firmly against the back rest.Grasp the handles with a pronated (overhand) grip.Plant your feet firmly on the ground.Exhale as you press the handles out until your arms are fully extended.Inhale as you reverse the motion until you feel a mild stretch in your chest.Repeat.",
                ExerciseName = "Machine chest press"
            },
            new Exercise
            {
                ExerciseName = "Decline barbell bench press",
                ExerciseDescription = "Lock your feet under the leg brace of a declined bench and lie on your back.Using a grip that is a little wider than shoulder width, dismount the barbell from the rack.While holding the barbell, retract your shoulder blades (push them together) and straighten your wrists.Keeping your elbows tucked in a little, inhale as you lower the barbell to your chest.Exhale as you press the barbell back up to the starting position.Repeat.",
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2016/10/Decline-Barbell-Bench-Press-990x461.png"
            },
            new Exercise
            {
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2016/11/incline-dumbbell-bench-press-990x735.png",
                ExerciseDescription = "Holding a dumbbell in each hand, sit on a bench inclined at 45 degrees and rest one dumbbell on each knee.As you lie back on the bench, kick the dumbbells up, one at a time, into place.Position the dumbbells to the sides of your chest, with your elbows bent and tucked in to your torso a little.Straighten your wrists.Spread your legs and place your feet flat on the floor.Exhale as you press the dumbbells upward and inward until your arms are almost fully extended and the dumbbells nearly touch.Hold for a count of two and squeeze your chest.Inhale as you lower the dumbbells back to the starting position, or until you feel a mild stretch in your chest.Repeat.",
                ExerciseName = "Incline dumbbell bench press"
            }
        };

        static ObservableCollection<Exercise> WendExer = new ObservableCollection<Exercise>()
        {
            new Exercise
            {
                ExerciseName = "Smith machine seated overhead press",
                ExerciseDescription = "Place a chair in the Smith machine, under the bar.Set the Smith machine bar at the same height that your head will be after you sit into position.Secure the safety pins of the Smith machine so that the bar cannot drop low and hurt you.Sit in position, plant your feet flat on the floor, and grasp the bar with a pronated (overhand) grip that is a little wider than shoulder width.Rotate the bar to unlatch it from the rail.Exhale as you press the bar upward until your arms are almost fully extended.Inhale as you lower the bar to your upper chest.Repeat for more repetitions.Once you have finished, rotate the bar to latch it back onto the rail.",
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2017/07/Smith-machine-seated-overhead-press-1-990x635.png"
            },
            new Exercise
            {
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2016/05/dumbbell-lateral-raise-990x755.png",
                ExerciseDescription = "Stand holding a dumbbell in each hand, with the dumbbells hanging down by your sides.Bend forward a little at the hips.Eternally rotate your shoulders so that your thumbs point out diagonally.Keeping your elbows slightly bent, exhale as you raise both upper arms out to the sides until your elbows are level with your shoulders.Hold for a count of two.Inhale as you lower the dumbbells to the starting position.Repeat for the recommended number of repetitions.",
                ExerciseName = "Dumbbell lateral raise"
            },
            new Exercise
            {
                ExerciseName = "Cable face pull",
                ExerciseDescription = "Stand in front of a pulley set at approximately head height.Grasp one end of the rope attachment in each hand using a supinated(underhand) grip.Step backward so that the rope is taut and your arms are stretched out in front of you.Assume a staggered stance(place one foot in front of the other) and lean backward to help you balance.Exhale as you pull the rope toward your forehead.As the rope nears your face, externally rotate your shoulders so that you end up making a double biceps pose.Hold for a count of two.Inhale as you reverse the motion and return the rope to the starting position in a controlled manner.Repeat.",
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2016/10/Face-pull-990x608.png"
            },
            new Exercise
            {
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2016/12/machine-chest-press-990x698.png",
                ExerciseDescription = "Sit on a chair or bench, preferably one with a back support, with a dumbbell on each knee.Kick the dumbbells up one at a time and position them in front of your shoulders, with your palms facing you and your elbows close to your body.Exhale as you press the dumbbells upward and rotate your wrists so that your palms face forward at the top of the movement.Inhale as you lower the dumbbells and rotate your palms so that they face you again at the bottom of the movement.Repeat.",
                ExerciseName = "Arnold press"
            },
            new Exercise
            {
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2016/11/incline-dumbbell-bench-press-990x735.png",
                ExerciseDescription = "Stand upright holding a barbell with a shoulder-width, overhand (pronated) grip. The bar should be resting on the front of your thighs.Pull your shoulders back and stick your chest out.Exhale as you pull the bar up towards your chin, making sure to stop when the bar is level with your lower or middle chest. Do not pull the bar any higher.Hold for a count of two.Inhale as you lower the bar to the starting position.Repeat for the recommended number of repetitions.",
                ExerciseName = "Barbell wide-grip upright row"
            }
        };

        static ObservableCollection<Exercise> FriExer = new ObservableCollection<Exercise>()
        {
            new Exercise
            {
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2017/08/machine-assisted-close-neutral-grip-pull-up-990x711.png",
                ExerciseDescription = "Kneel onto the padded platform of the assisted pull-up machine and grasp the close parallel bars.Allow your body to descend until your arms are fully extended and your shoulders are stretched upward.Exhale as you pull your body upward until your elbows are by the sides of your body.Hold for a count of two and squeeze your back muscles.Inhale as you lower your body in a controlled manner until your arms are fully extended and your shoulders are stretched upward.Repeat.",
                ExerciseName = "Machine-assisted close neutral-grip pull-up"
            },
            new Exercise
            {
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2017/01/Machine-one-arm-row-990x590.png",
                ExerciseDescription = "Adjust the machine’s seat and chest pad for optimal comfort and range of motion.Sit on the machine.Position your chest against the front pad.Plant your feet firmly on the floor.Grasp the handles. Your arms and shoulders should be stretched forward.Keeping your back straight, exhale as you pull one of the handles to the side of your waist.Hold for a count of two, stick out your chest, and squeeze your back muscles.Inhale as you slowly return the handle to the starting position.Repeat for the prescribed number of repetitions.Repeat the exercise with your opposite arm.",
                ExerciseName = "Machine one-arm row"
            },
            new Exercise
            {
                ExerciseName = "Bent-over barbell row",
                ExerciseDescription = "Stand over a loaded barbell, with the bar lining up with your toes.Bend at the hips and a little at the knees and grasp the barbell with hands a little wider than shoulder width apart. Your back should be straight and close to horizontal.Exhale as you pull the barbell up to your waist.Hold for a count of two and squeeze your back muscles.Inhale as you lower the barbell in a controlled manner until it nearly touches the floor.Repeat.",
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2016/10/Barbell-Bent-Over-Row-990x494.png"
            },
            new Exercise
            {
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2016/05/cablerow-990x548.png",
                ExerciseDescription = "Sit facing the cable row machine and place your feet on the foot rests.Grasp the double-row bar and slide your bottom backward until your knees are almost straight. You torso should be leaning forward and your arms and shoulders should be stretching forward.Exhale as you slowly lean backward, straighten your back, and pull the v-bar to your abdomen, keeping your elbows close to your body. Pull your shoulders back and stick out your chest at the top of the movement.Hold for a count of two and squeeze your back muscles.Inhale as you slowly lean forward and return the double-row bar to the starting position, with your arms and shoulders stretching forward and your lower back bent forward.Repeat for the recommended number of repetitions.",
                ExerciseName = "Seated cable row"
            },
            new Exercise
            {
                ExerciseName = "Wide-grip lat pull-down",
                ExerciseDescription = "Choose your weight and sit on the lat pull-down machine, adjusting it so that your thighs fit under the supports.Grasp the bar with a pronated (overhand) grip, with your hands more than shoulder-width apart.Exhale as you slowly pull the bar down until it touches the upper part of your chest.Squeeze your shoulder blades together and hold for a count of two.Inhale as you slowly return the bar to the starting position.Repeat for the recommended number of repetitions.",
                ExerciseImage = "https://weighttraining.guide/wp-content/uploads/2016/05/wide-grip-lat-pulldown-990x771.png"
            },
        };

        Dictionary<string, ObservableCollection<Exercise>> item = new Dictionary<string, ObservableCollection<Exercise>>();
        Dictionary<string, ObservableCollection<Exercise>> item2 = new Dictionary<string, ObservableCollection<Exercise>>();
        Dictionary<string, ObservableCollection<Exercise>> item3 = new Dictionary<string, ObservableCollection<Exercise>>();

        static private ObservableCollection<Program> _myPrograms;

        static public ObservableCollection<Program> MyProgram
        {
            get { return _myPrograms; }
            set { _myPrograms = value; }
        }


        static private ObservableCollection<Program> _allPrograms;

        static public ObservableCollection<Program> AllPrograms
        {
            get { return _allPrograms; }
            set { _allPrograms = value; }
        }

        private static ObservableCollection<User> _users;

        public static ObservableCollection<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        public static User SelectedUser { get; set; }

        /*_________________________________________________________________________________________________________________
                                                                LoginPage v
          _________________________________________________________________________________________________________________*/


        public string SignInEmail { get; set; }
        public string SignInPassword { get; set; }

        /*_________________________________________________________________________________________________________________
                                                                LoginPage ^
          _________________________________________________________________________________________________________________*/

        /*_________________________________________________________________________________________________________________
                                                                Commands v
          _________________________________________________________________________________________________________________*/




        /*_________________________________________________________________________________________________________________
                                                                Commands ^
          _________________________________________________________________________________________________________________*/

        public App()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            Users = new ObservableCollection<User>
            {
                new User
                {
                    Arms = 40,
                    Calves = 50,
                    Chest = 100,
                    DayOfBirth = new DateTime(1998, 02, 20),
                    Email = "rauf.jafarov145@gmail.com",
                    FirstName = "Rauf",
                    Gender = "Male",
                    Height = 184,
                    LastName = "Jafarov",
                    Password = "qwerty123",
                    Quads = 50,
                    Shoulders = 70,
                    Waist = 40,
                    Weight = 50,
                },
                new User
                {
                    Arms = 40,
                    Calves = 50,
                    Chest = 100,
                    DayOfBirth = new DateTime(1998, 02, 20),
                    Email = "AliyevAzer@gmail.com",
                    FirstName = "Azer",
                    Gender = "Male",
                    Height = 184,
                    LastName = "Aliyev",
                    Password = "raufkrut",
                    Quads = 50,
                    Shoulders = 70,
                    Waist = 40,
                    Weight = 50,
                },
                new User
                {
                    Arms = 50,
                    Calves = 50,
                    Chest = 100,
                    DayOfBirth = new DateTime(1998, 02, 20),
                    Email = "MahmudovAli@gmail.com",
                    FirstName = "Ali",
                    Gender = "Male",
                    Height = 190,
                    LastName = "Mahmudov",
                    Password = "asdf",
                    Quads = 50,
                    Shoulders = 60,
                    Waist = 40,
                    Weight = 50,
                }
            };

            item.Add("Monday", MondayExer);
            item.Add("Wendsday", WendExer);
            item.Add("Friday", FriExer);

            item2.Add("Monday", WendExer);
            item2.Add("Wendsday", FriExer);
            item2.Add("Friday", MondayExer);

            item3.Add("Monday", FriExer);
            item3.Add("Wendsday", WendExer);
            item3.Add("Friday", MondayExer);

            SelectedUser = Users[0];

            tabbedPage.Children.Add(new ProfilePage());
            tabbedPage.Children.Add(new BodyPage());
            tabbedPage.Children.Add(new PicturesPage());

            AllPrograms = new ObservableCollection<Program>()
            {
                new Program()
                {
                    ProgramName = "Azer program",
                    user = Users[1],
                    Raiting = 5,
                    ExerciseList = item
                },
                new Program()
                {
                    ProgramName = "Rauf program",
                    user = Users[0],
                    Raiting = 0,
                    ExerciseList = item2
                },
                new Program()
                {
                    ProgramName = "Ali program",
                    user = Users[2],
                    Raiting = 5,
                    ExerciseList = item3
                }
            };

            MyProgram = new ObservableCollection<Program>();
            MyProgram.Add(AllPrograms[1]);

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
