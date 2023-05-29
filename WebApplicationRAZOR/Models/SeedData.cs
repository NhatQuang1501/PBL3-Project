using Microsoft.EntityFrameworkCore;
using PBL3_Project.Data;
using WebApplicationRAZOR.Pages.Admin.QLACGS;

namespace PBL3_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PBL3_ProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PBL3_ProjectContext>>()))
            {
                if (context == null || context.AccountGiaSu == null)
                {
                    throw new ArgumentNullException("Null PBL3_ProjectContext");
                }

                // Look for any accounts.
                if (context.AccountGiaSu.Any())
                {
                    return;   // DB has been seeded
                }

                context.AccountGiaSu.AddRange(
                    new AccountGiaSu
                    {
                        ID_GiaSu = 1,
                        TenAcc = "tutor1",
                        PasswordAcc = "tutor1"
                    },

                    new AccountGiaSu
                    {
                        ID_GiaSu = 2,
                        TenAcc = "tutor2",
                        PasswordAcc = "tutor2"
                    },

                    new AccountGiaSu
                    {
                        ID_GiaSu = 3,
                        TenAcc = "tutor3",
                        PasswordAcc = "tutor3"
                    }      
                );
                context.SaveChanges();
            }

            using (var context = new PBL3_ProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PBL3_ProjectContext>>()))
            {
                if (context == null || context.AccountPhuHuynh == null)
                {
                    throw new ArgumentNullException("Null PBL3_ProjectContext");
                }

                // Look for any accounts.
                if (context.AccountPhuHuynh.Any())
                {
                    return;   // DB has been seeded
                }

                context.AccountPhuHuynh.AddRange(
                    new AccountPhuHuynh
                    {
                        ID_PhuHuynh = 01,
                        TenAcc = "parent1",
                        PasswordAcc = "parent1",
                    },

                    new AccountPhuHuynh
                    {
                        ID_PhuHuynh = 02,
                        TenAcc = "parent2",
                        PasswordAcc = "parent2",
                    },

                    new AccountPhuHuynh
                    {
                        ID_PhuHuynh = 03,
                        TenAcc = "parent3",
                        PasswordAcc = "parent3",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
