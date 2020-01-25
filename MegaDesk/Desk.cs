using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer,
    };
    
    public class Desk
    {
        int deskWidth;
        int deskDepth;
        int drawers;
        String desktopSurface;
       

        AddQuote form = new AddQuote();


        public Desk(int deskWidth, int deskDepth, int drawers, String desktopSurface)
        {
            this.deskWidth = deskWidth;
            this.deskDepth = deskDepth;
            this.drawers = drawers;
            this.desktopSurface = desktopSurface;
        }

       
        public int getdeskDepth()
        {
            
            return deskDepth;
        }
        public int getdeskWidth()
        {
            
            return deskWidth;
        }
        public int getDrawers()
        {
            
            return drawers;
        }
        public string getdesktopSurface()
        {
            
            return desktopSurface;
        }
        

        private void setdeskDepth(int deskdepth)
        {
            this.deskDepth = deskdepth;
        }
        private void setdeskWidth(int deskwidth)
        {
            this.deskWidth = deskwidth;
        }
        private void setDrawers(int Drawers)
        {
            this.drawers = Drawers;
        }
        private void setdesktopSurface(String desktopsurface)
        {
            this.desktopSurface = desktopsurface;
        }
     

    }
}
