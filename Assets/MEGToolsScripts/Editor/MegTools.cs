using UnityEditor;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;
using UnityEngine;

namespace MEGEditorTools
{
    public static class MegTools
    {

        /*    
         *    If you want it to appear under the main tools category,
         *      add "Tools/" in front of the "MEG Tools" category name. 
         */

        #region Create Folders

        [MenuItem("MEG Tools/Create Folders/Basic Folders [Create]")]
        public static void CreateBasicFolders()
        {
            // Ana klasörler
            Dir("_Project", "Arts", "Prefabs", "Scripts", "Audio", "Scenes", "UI");

            // Arts - Sanatsal içerikler için
            Dir("_Project/Arts", "Models", "Sprites", "Animations", "Particles");

            // Prefabs - Prefab yapýlarý için
            Dir("_Project/Prefabs", "Characters", "Environment", "UI");

            // Scripts - Kodlar için
            Dir("_Project/Scripts", "Core", "Managers", "UI");
            Dir("_Project/Scripts/Core", "Player", "Enemy");
            Dir("_Project/Scripts/Managers", "GameManager", "UIManager", "AudioManager");

            // Audio - Ses dosyalarý için
            Dir("_Project/Audio", "Music", "SFX");

            // Scenes - Sahne dosyalarý için
            Dir("_Project/Scenes", "MainMenu", "GameScene");

            // UI - Kullanýcý arayüzü için
            Dir("_Project/UI", "Elements", "Icons");

            Refresh();
        }


        [MenuItem("MEG Tools/Create Folders/Detailed Folders [Create]")]
        public static void CreateDetailedFolders()
        {
            // Ana klasörler
            Dir("_Project", "Arts", "Audio", "Materials", "Prefabs", "Resources", "Scenes", "Scripts", "Settings", "Shaders", "UI");

            // Arts - Sanat varlýklarý için
            Dir("_Project/Arts", "Animations", "Models", "Textures", "Sprites", "Particles", "Fonts");
            Dir("_Project/Arts/Animations", "CharacterAnimations", "EnvironmentAnimations", "UIAnimations");
            Dir("_Project/Arts/Models", "Characters", "Environment", "Props", "Vehicles");
            Dir("_Project/Arts/Textures", "Characters", "Environment", "Props", "UI");
            Dir("_Project/Arts/Sprites", "UI", "Environment", "Characters", "Icons");

            // Audio - Ses dosyalarý için
            Dir("_Project/Audio", "Music", "SFX", "VoiceOver", "Ambient");
            Dir("_Project/Audio/Music", "BackgroundMusic", "MenuMusic");
            Dir("_Project/Audio/SFX", "CharacterSFX", "EnvironmentSFX", "UISFX");

            // Materials - Materyaller için
            Dir("_Project/Materials", "Characters", "Environment", "Props", "UI");

            // Prefabs - Prefab yapýlarý için
            Dir("_Project/Prefabs", "Characters", "Environment", "UI", "Items", "Vehicles", "Weapons");

            // Resources - Kaynaklar için (genellikle script ile eriþilecek varlýklar)
            Dir("_Project/Resources", "Audio", "Prefabs", "Textures", "Fonts", "Materials");

            // Scenes - Sahne dosyalarý için
            Dir("_Project/Scenes", "MainMenu", "Levels", "Testing", "Cutscenes");
            Dir("_Project/Scenes/Levels", "Level1", "Level2", "Level3");
            Dir("_Project/Scenes/Testing", "PhysicsTesting", "AIBehaviorTesting");

            // Scripts - Kodlar için
            Dir("_Project/Scripts", "Core", "Gameplay", "UI", "Managers", "Utilities", "Data");
            Dir("_Project/Scripts/Core", "Player", "Enemy", "NPC", "AI");
            Dir("_Project/Scripts/Gameplay", "Combat", "Inventory", "Quests", "Interactions");
            Dir("_Project/Scripts/UI", "Menus", "HUD", "Popups", "Widgets");
            Dir("_Project/Scripts/Managers", "AudioManager", "GameManager", "LevelManager", "UIManager");
            Dir("_Project/Scripts/Utilities", "Helpers", "Extensions", "CustomEvents");

            // Settings - Proje ayarlarý için
            Dir("_Project/Settings", "InputSettings", "GraphicsSettings", "AudioSettings", "PhysicsSettings");

            // Shaders - Shader dosyalarý için
            Dir("_Project/Shaders", "SurfaceShaders", "UnlitShaders", "PostProcessing");

            // UI - Kullanýcý Arayüzü için
            Dir("_Project/UI", "Canvases", "Elements", "Icons", "Fonts", "Prefabs", "Animations");

            Refresh();
        }

        #endregion

        #region Add Scripts

        [MenuItem("MEG Tools/Add Scripts/Add Basic Scripts")]
        public static void AddBasicScripts()
        {
            //Unity AssetStore içinde Bir Asset oluþturma ve bu assete yönlendirme
            OpenURL(@"https://github.com/Muh-Emir/MegToolsProject");
        }

        [MenuItem("MEG Tools/Add Scripts/Add Pro Scripts")]
        public static void AddProScripts()
        {
            //Unity AssetStore içinde Bu Asseti oluþturma ve bu assete yönlendirme
            OpenURL(@"https://github.com/Muh-Emir/MegToolsProject");
        }

        #endregion

        #region Add Assets

        [MenuItem("MEG Tools/Add Assets/Custom Assets/My Favorite List [Link]")]
        public static void DonwloadFpsCounterAsset()
        {
            //Unity AssetStore içinde Bir Standart Assetler listesine yönlendirme
            OpenURL(@"https://assetstore.unity.com/packages/tools/gui/graphy-ultimate-fps-counter-stats-monitor-debugger-105778");
        }

        [MenuItem("MEG Tools/Add Assets/Custom Assets/Basic Fps Counter [Link]")]
        public static void BasicFpsCounterAsset()
        {
            //Github'daki Unity basics projemdeki scriptlere gider
            OpenURL(@"https://github.com/Muh-Emir");
        }

        [MenuItem("MEG Tools/Add Assets/Custom Assets/Pro Fps Counter [Link]")]
        public static void ProFpsCounterAsset()
        {
            //Unity AssetStore içinde Bir Standart Assetler listesine yönlendirme
            OpenURL(@"https://assetstore.unity.com/packages/tools/gui/graphy-ultimate-fps-counter-stats-monitor-debugger-105778");
        }

        #endregion

        #region End Of List

        [MenuItem("MEG Tools/Youtube Video List [Link]")]
        public static void GoToVideoList()
        {
            //Youtube video listesi oluþturup bu listeye yönlendirme
            OpenURL(@"https://youtube.com");
        }

        [MenuItem("MEG Tools/MEG Github [Link]")]
        public static void MegGithub()
        {
            //My Github profile
            OpenURL(@"https://github.com/Muh-Emir");
        }

        #endregion


        static void Dir(string root)
        {
            var fullPath = Combine(dataPath, root);
            CreateDirectory(fullPath);
        }

        static void Dir(string root, params string[] dir)
        {
            var fullPath = Combine(dataPath, root);
            foreach (var newDir in dir)
            {
                CreateDirectory(Combine(fullPath, newDir));
            }
        }
    }
}