using System;

namespace CCChecker
{
    public class CreditCard
    {
        public long CardNumber;
           
        public string IssuingNetwork;
        public CreditCard(long CardNumber, string IssuingNetwork)
        {
            this.CardNumber = CardNumber;
            this.IssuingNetwork = IssuingNetwork;
        }
    
        public bool Validate()
        {
            string ccstring = CardNumber.ToString();
            char[] chars = ccstring.ToCharArray();
            if(chars.Length <= 19)
            {
                int sum = 0;
                for(int i= 0; i < chars.Length; i++)
                {
                    if(i % 2 == 0)
                    {
                        int value = Int32.Parse(chars[i].ToString());
                        value = value * 2;
                        if (value > 9)
                        {
                            sum += (1 + (value % 10));
                        }
                        else
                        {
                            sum += value;
                        }
                    }
                    else
                    {
                        sum += Int32.Parse(chars[i].ToString());
                    }
                }
                if (sum % 10 == 0)
                {
                    return true;
                }
                else
                {
                    return false;    
                }
            }
            else
            {
                return false;
            }
        }
    }
}
