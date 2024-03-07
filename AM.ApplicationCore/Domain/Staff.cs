﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
    public class Staff: Passenger
    {
        public string Function { get; set; }

        [Range(0, double.MaxValue)]
        public double Salary { get; set; }
        public DateTime EmployementDate { get; set; }

        public override void PassengerType()
        {
           // base.PassengerType();
            Console.WriteLine("I am a staff member");
        }

    }
}
