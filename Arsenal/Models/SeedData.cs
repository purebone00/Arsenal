using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Arsenal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Arsenal.Models.ArsenalDataModels;

namespace Arsenal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ArsenalContext(
                serviceProvider.GetRequiredService<DbContextOptions<ArsenalContext>>()))
            {
                // Looks for Transactions in the database
                if (context.Transaction.Any())
                {
                    return; //Database has been already seeded
                }

                context.Transaction.AddRange(
                    new Transaction
                    {
                        TransactionDate = DateTime.Parse("2019-01-08"),
                        Description = "Esso",
                        TotalAmount = 50.00,
                        GstAmount = 2.38,
                        PstAmount = 0,
                        PaymentType = "GAS",
                        CreditCardLastFourDigits = "2852"
                    },

                    new Transaction
                    {
                        TransactionDate = DateTime.Parse("2019-01-09"),
                        Description = "The Home Depot",
                        TotalAmount = 24.00,
                        GstAmount = 4.38,
                        PstAmount = 6.25,
                        PaymentType = "SUPPLIES",
                        CreditCardLastFourDigits = "2852"
                    },

                    new Transaction
                    {
                        TransactionDate = DateTime.Parse("2019-01-10"),
                        Description = "Chevron",
                        TotalAmount = 14.00,
                        GstAmount = 0.38,
                        PstAmount = 0.42,
                        PaymentType = "GAS",
                        CreditCardLastFourDigits = "2852"
                    }

                    ) ;

                context.SaveChanges();
            }
        }
    }
}
