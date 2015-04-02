using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormationMVC.Library;
using System.Linq;

namespace FormationMVC.Tests.Model
{
    /// <summary>
    /// Description résumée pour ModelTest
    /// </summary>
    [TestClass]
    public class ModelTest
    {
        public ModelTest()
        {
            //
            // TODO: ajoutez ici la logique du constructeur
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        //
        // Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        // Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test de la classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilisez ClassCleanup pour exécuter du code une fois que tous les tests d'une classe ont été exécutés
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ContextTest()
        {
            ProductContext context = new ProductContext();
            int i = context.VideoRecordings.Count();
            Assert.IsTrue(i >= 0);
        }

        [TestMethod]
        public void RepositoryTest()
        {
            VideoRecordingRepository repo = new VideoRecordingRepository();
            ProductContext context = new ProductContext();
            repo.Context = context;
            int c = repo.Count();
            Assert.IsTrue(c >= 0);
        }

        [TestMethod]
        public void MainServiceTest()
        {
            IMainService service = new MainService();
            VideoRecordingRepository repo = new VideoRecordingRepository();
            ProductContext context = new ProductContext();
            repo.Context = context;
            service.VideoRecordingRepository = repo;
            VideoRecording vr = service.GetVideoRecordingById(1);
            Assert.IsNotNull(vr);
            Assert.AreEqual(1, vr.Id);
        }

        [TestMethod]
        public void UnityTest()
        {
            IMainService service = UnityHelper.Resolve<IMainService>();
            VideoRecording vr = service.GetVideoRecordingById(1);
            Assert.IsNotNull(vr);
            Assert.AreEqual(1, vr.Id);
        }


    }
}
