using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMLaDoctaCines
{
    class TestTablaColor : ProfessionalColorTable
    {
        public TestTablaColor()
        {
            // see notes
            base.UseSystemColors = false;
        }

        //
        public override Color MenuBorder => Color.FromArgb(39, 26, 34);

        // Borde cuando pasas el mouse arriba en el SubMenu
        public override Color MenuItemBorder => Color.Transparent;

        // Fondo cuando pasas el mouse arriba en el Desplegable
        public override Color MenuItemSelected => Color.FromArgb(70, 30, 39);

        // Fondo cuando pasas el mouse arriba en el SubMenu
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(70, 30, 39);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(70, 30, 39);

        // ???
        public override Color MenuStripGradientBegin => Color.FromArgb(39, 26, 34);
        public override Color MenuStripGradientEnd => Color.FromArgb(39, 26, 34);

        // SubMenu seleccionado
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(70, 30, 39);
        public override Color MenuItemPressedGradientMiddle => Color.FromArgb(70, 30, 39);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(70, 30, 39);

        // Columna izq del Desplegable
        public override Color ImageMarginGradientBegin => Color.FromArgb(39, 26, 34);

        public override Color ImageMarginGradientMiddle => Color.FromArgb(39, 26, 34);

        public override Color ImageMarginGradientEnd => Color.FromArgb(39, 26, 34);

        // Color de fondo del Desplegable
        public override Color ToolStripDropDownBackground => Color.FromArgb(96, 58, 72);
        //public override Color ToolStripDropDownBackground => Color.FromArgb(96, 58, 72);

    }

}
