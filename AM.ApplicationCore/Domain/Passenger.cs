using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int PassengerId { get; set; }

        public FullName fullName { get; set; }

        [StringLength(7)]
        public string PassportNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Le numéro de téléphone doit contenir 8 chiffres")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Flight>? Flights { get; set; }

        public virtual ICollection<Ticket>? Tickets { get; set; }

        public override string ToString()
        {
            return $"PassengerId : {PassengerId} - " +
                $" FullName :{fullName}  - PassportNumber: {PassportNumber} -" +
                $" EmailAddress : {EmailAddress} - PhoneNumber : {PhoneNumber} - BirthDate : {BirthDate}";
        }

        public bool CheckProfile(string LastName, string FirstName)
        {
            return this.fullName.LastName == LastName && this.fullName.FirstName == FirstName;
        }

        public bool CheckProfile(string LastName, string FirstName, string EmailAddress)
        {
            return this.fullName.LastName == LastName && this.fullName.FirstName == FirstName && this.EmailAddress == EmailAddress;
        }

        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passanger ");
        }
    }
}
