using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIBank.Models.Context;
using WebAPIBank.Models.Entities;

namespace WebAPIBank.Models.Init
{
    

    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {

        protected override void Seed(MyContext context)
        {
            CustomerCardInfo cif = new CustomerCardInfo();
            cif.CardUserName = "Erdal Goksen";
            cif.CardNumber = "1111 1111 1111 1111";
            cif.CardExpiryYear = 2022;
            cif.CardExpiryMonth = 12;
            cif.SecurityNumber = "222";
            cif.Limit = 30000;
            cif.Balance = 30000;
            context.Cards.Add(cif);
            context.SaveChanges();
        }

    }
}