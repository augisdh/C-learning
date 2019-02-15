using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTrack
{
    interface IPayee
    {
        void Pay();
    }

    class PayRoll
    {
        List<IPayee> payees = new List<IPayee>();

        public PayRoll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());

            Logger.Log("PayRoll started", "PayRoll");
        }

        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }

            Logger.Log("PayAll completed", "PayAll", 2);
        }
    }
}
