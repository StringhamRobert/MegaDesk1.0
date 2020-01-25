using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class DeskQuote
    {
        String customerName;
        Desk Desk;
        int surfaceCost;
        int area;
        int Quote;
        String deliveryOption;
        DateTime date;



        public DeskQuote(Desk Desk, string customerName, string deliveryOption)
        {
            this.Desk = Desk;
            this.customerName = customerName;
            this.deliveryOption= deliveryOption;
            this.date = DateTime.Now;
        }
        public int deskArea()
        {
            return Desk.getdeskDepth() * Desk.getdeskDepth();
            
        }
        public int surfacePayment()
        {
            if(Desk.getdesktopSurface() == "Oak")
            {
                surfaceCost = 200;
            }
            else if(Desk.getdesktopSurface() == "Laminate")
            {
                surfaceCost = 100;
            }
            else if(Desk.getdesktopSurface() == "Pine")
            {
                surfaceCost = 50;
            }
            else if(Desk.getdesktopSurface() == "Rosewood")
            {
                surfaceCost = 300;
            }
            else
            {
                surfaceCost = 125;
            }
            return surfaceCost;
        }

        public int delivery()
        {
            int area = deskArea();
            if(deliveryOption == "3 Day")
            {
                if(area > 1000){
                    return 60;
                }
                else if(area > 1000 && area < 2000)
                {
                    return 70;
                }
                else
                {
                    return 80;
                }
            }
            else if(deliveryOption == "5 Day")
            {
                if (area > 1000)
                {
                    return 40;
                }
                else if (area > 1000 && area < 2000)
                {
                    return 50;
                }
                else
                {
                    return 60;
                }
            }
            else if(deliveryOption == "7 Day")
            {
                if (area > 1000)
                {
                    return 30;
                }
                else if (area > 1000 && area < 2000)
                {
                    return 35;
                }
                else
                {
                    return 40;
                }
            }
            else
            {
                return 0;
            }
            
        }

        public int singleQuote() {
            return 200 + (Desk.getDrawers() * 50) + (deskArea() * 1) + delivery() + surfacePayment(); 
            
        }
      
       
    }
}
