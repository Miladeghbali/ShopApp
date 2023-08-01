using System;
using System.Linq;
using System.Windows.Forms;
using ShopApp.RepositoryAbstracts;
using ShopApp.Framework.ExtensionMethods;

namespace ShopApp.WinClinet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Framework.Cultures.InitializePersianCulture();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #region
            /// <summary>
            /// تنظیمات  ارتباط 
            /// </summary>
            var container = new StructureMap.Container(new Ioc.TypesRegistry());
            var splashForm = container.GetInstance<Views.SystemForrms.SplashScreenForm>();
            var result=splashForm.ShowDialog();
            if (result != DialogResult.OK)
                return;
            #endregion
            #region
            /// <summary>
            /// چک کردن کاربر
            /// </summary>
            var UsersRepo = container.GetInstance<IUsersRepository>();
            if (UsersRepo.Count() == 0)
            {
                UsersRepo.Add(new Entities.User
                {
                    Username = "admin"
                });
            }
            #endregion
            #region 
            /// <summary>
            /// وارد کردن اطلاعات شرکت ها
            /// </summary>
            var corporationRepo = container.GetInstance<ICorporationsRepository>();
            if (corporationRepo.Count() == 0)
            {
                var corporationEditorForm = new Views.SystemForrms.CorporationEditorForm();
                var corporionEntity = new Entities.Corporation();
                corporationEditorForm.Corporation = corporionEntity;
                if (corporationEditorForm.ShowDialog() == DialogResult.OK)
                {
                    corporationRepo.Add(corporionEntity);
                }
                else
                {
                    Application.Exit();
                    return;
                }
            }
            #endregion
            #region
            /// <summary>
            /// سال مالی
            /// </summary>
            var financialYearsRepo = container.GetInstance<IFinancialYearsRepository>();
            if (financialYearsRepo.Count() == 0)
            {
                var corporation = corporationRepo.All().First();
                var financialYearModel = new Models.FinancialYearModel();
                var financialYearEditorForm = new Views.SystemForrms.FinancialYearEditorForm();
                financialYearEditorForm.FinancialYear = financialYearModel;
                if (financialYearEditorForm.ShowDialog() == DialogResult.OK)
                {
                    var finacialYear = new Entities.FinancialYear();
                    finacialYear.CorporationsId = corporation.ID;
                    finacialYear.Title = financialYearModel.Title;
                    finacialYear.Description = financialYearModel.Description;
                    finacialYear.StartDate = financialYearModel.StartDate.ConvertToDate()??DateTime.Now;
                    finacialYear.FinishDate = financialYearModel.FinishDate.ConvertToDate()??DateTime.Now;
                    financialYearsRepo.Add(finacialYear);
                  
                }
                else
                {
                    Application.Exit();
                    return;

                }
            }
            #endregion
            Application.Run(new MainForm());
        }
    }
}
