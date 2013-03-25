/*  MVC Boilerplate SlickGrid Shim
https://github.com/stephen-james/MVCBoilerplate

In the SlickGrid CSS it is mentioned that :

"In order to preserve the uniform grid appearance, all cell styles need to have padding, margin and border sizes.
No built-in (selected, editable, highlight, flashing, invalid, loading, :focus) or user-specified CSS classes should alter those!"

While this is preferable, sometimes we want to style slickgrid sizes dynamically using CSS, so I've added this dynamic option extender to be used for initialising slickgrid, 
it will create fakes based on the target grid and set the sizes in the options dynamically.

*/

var MvcBoilerPlate = MvcBoilerPlate || {};

MvcBoilerPlate.SlickGrid = MvcBoilerPlate.SlickGrid ||
{
    dynamicSizeOptions: function (options, targetGrid) {


        var fakeTarget = $(targetGrid)
                            .clone()
                            .css("visibility", "hidden !important")
                            .css("position", "absolute !important")
                            .css("left", "-1000px !important")
                            .css("top", "-1000px !important")
                            .append("<div class='slick-header ui-state-default' style='overflow:hidden;position:relative;'><div class='slick-header-columns' style='left: -1000px; width: 1600px; ' unselectable='on'><div class='ui-state-default slick-header-column' id='slickgrid_853820title' style='width: 71px; ' title=''><span class='slick-column-name'>Title</span><div class='slick-resizable-handle'></div></div></div></div>")
                            .append("<div class='slick-viewport' style='width: 100%; overflow: auto; outline: 0px; position: relative; height: 474px; '><div class='grid-canvas' style='height: 12500px; width: 480px; '><div class='ui-widget-content slick-row even' style='top:0px'><div class='slick-cell l0 r0'>Task 0</div></div></div></div></div>")
                            .appendTo($("body"));

        var rowHeight = fakeTarget.find(".slick-cell").outerHeight();
        var headerRowHeight = fakeTarget.find(".slick-header-column").outerHeight();
        var topPanelHeight = headerRowHeight;

        options = $.extend({}, options, { "rowHeight": rowHeight, "headerRowHeight": headerRowHeight, "topPanelHeight": topPanelHeight });

        fakeTarget.remove();

        return options;
    }
}