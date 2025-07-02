using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    public class RhinoInfo : GH_AssemblyInfo
    {
        public override string Name => "DiGi.Analytical.Building.Rhino";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("886667e5-8cdc-4cd7-9718-de3ec0d324e0");

        //Return a string identifying you or your company.
        public override string AuthorName => "Jakub Ziolkowski";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}

