﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Client.Models.DB;

namespace Client.Models
{
    public class AccountCustomer : Account
    {
        public Account account { get; set; }
        public Customer customer { get; set; }
        public Img img { get; set; }
        public List<Detail> details { get; set; }
        public List<Payment> payments { get; set; }
         public string messsage { get; set; }

        public AccountCustomer()
        {
            account = new Account();
            customer = new Customer();
            img = new Img();
            details = new List<Detail>();
            payments = new List<Payment>();
            messsage = "";
        }

        public AccountCustomer(Account account, Customer customer, Img img, List<Detail> details, List<Payment> payments)
        {
            this.account = account ?? throw new ArgumentNullException(nameof(account));
            this.customer = customer ?? throw new ArgumentNullException(nameof(customer));
            this.img = img;
            this.details = details;
            this.payments = payments;
        }
    }
}