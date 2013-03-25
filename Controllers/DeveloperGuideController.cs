using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Boilerplate.Controllers
{
    public class DeveloperGuideController : Controller
    {
        public ActionResult BuiltOn()
        {
            return View();
        }

        public ActionResult Conventions()
        {
            return View();
        }

        public ActionResult StyleGuide()
        {
            return View("Index");
        }

        
        //
        // GET: /StyleGuide/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menus()
        {

            return ShowGuideSection("Menu");
        }

        public ActionResult Tabs()
        {
            return ShowGuideSection("Tabs");
        }

        public ActionResult Grids()
        {
            return ShowGuideSection("Grids");
        }

        public ActionResult Tables()
        {
            return ShowGuideSection("Tables");
        }

        public ActionResult Accordions()
        {
            return ShowGuideSection("Accordions");
        }

        public ActionResult InputWidgets()
        {
            return ShowGuideSection("InputWidgets");
        }

        public ActionResult ShowGuideSection(string sectionName)
        {
            switch (sectionName)
            {
                case "ColourSchema" :
                    ViewBag.SectionAnchorName = "dev-guide-colourschema";
                    ViewBag.SectionName = "_ColourSchema";
                    ViewBag.SectionFriendlyName = "Colour Schema";
                    break;
                case "Forms":
                    ViewBag.SectionAnchorName = "dev-guide-forms";
                    ViewBag.SectionName = "_Forms";
                    ViewBag.SectionFriendlyName = "Forms";
                    break;
                case "Grids":
                    ViewBag.SectionAnchorName = "dev-guide-grids";
                    ViewBag.SectionName = "_Grids";
                    ViewBag.SectionFriendlyName = "Grids";
                    break;
                case "Tables":
                    ViewBag.SectionAnchorName = "dev-guide-tables";
                    ViewBag.SectionName = "_Tables";
                    ViewBag.SectionFriendlyName = "Tables";
                    break;
                case "InlineStyles":
                    ViewBag.SectionAnchorName = "dev-guide-inlinestyles";
                    ViewBag.SectionName = "_InlineStyles";
                    ViewBag.SectionFriendlyName = "Inline Styles";
                    break;
                case "Menu":
                    ViewBag.SectionName = "_Menu";
                    ViewBag.SectionAnchorName = "dev-guide-menu";
                    ViewBag.SectionFriendlyName = "Menu";
                    break;
                case "Tabs":
                    ViewBag.SectionAnchorName = "dev-guide-tabs";
                    ViewBag.SectionName = "_Tabs";
                    ViewBag.SectionFriendlyName = "Tabs";
                    break;
                case "Accordions" :
                    ViewBag.SectionAnchorName = "dev-guide-accordions";
                    ViewBag.SectionName = "_Accordions";
                    ViewBag.SectionFriendlyName = "Accordions";
                    break;
                case "InputWidgets":
                    ViewBag.SectionAnchorName = "dev-guide-inputwidgets";
                    ViewBag.SectionName = "_InputWidgets";
                    ViewBag.SectionFriendlyName = "Input Widgets";
                    break;
                default :
                    ViewBag.SectionName = "_Blank";
                    break;
            }

            return View("GuideSection");
        }
    }
}
