#pragma checksum "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36680b9cf4cf2b811f8e726f4b160b81e7fb8668"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MoviesReviewApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(MoviesReviewApp.Pages.Pages_Index), null)]
namespace MoviesReviewApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\_ViewImports.cshtml"
using MoviesReviewApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36680b9cf4cf2b811f8e726f4b160b81e7fb8668", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a72ebd1a2b2c0526a620c8f4e0550178b6bc1bca", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
  

    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(73, 81, true);
            WriteLiteral("\r\n<div>\r\n    <div class=\"container\">\r\n        <div class=\"slideshow-container\">\r\n");
            EndContext();
#line 11 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
             foreach (var item in Model.Index.results.OrderByDescending(res => res.release_date).Take(5))
            {


#line default
#line hidden
            BeginContext(278, 102, true);
            WriteLiteral("                <div class=\"mySlides row\">\r\n                    <img class=\"images img-fluid col-md-4\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 380, "\"", 405, 1);
#line 15 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 386, item.imageFullpath, 386, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 406, "\"", 423, 1);
#line 15 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 412, item.title, 412, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(424, 101, true);
            WriteLiteral(" />\r\n                    <div class=\"text col-md-7\">\r\n                        <p class=\"movie-title\">");
            EndContext();
            BeginContext(526, 40, false);
#line 17 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
            EndContext();
            BeginContext(566, 82, true);
            WriteLiteral("</p>\r\n                        <p>\r\n\r\n                            Rating: &#11088; ");
            EndContext();
            BeginContext(649, 47, false);
#line 20 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.vote_average));

#line default
#line hidden
            EndContext();
            BeginContext(696, 62, true);
            WriteLiteral("/10 &nbsp;  &nbsp;\r\n                            Release Date: ");
            EndContext();
            BeginContext(759, 47, false);
#line 21 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                     Write(Html.DisplayFor(modelItem => item.release_date));

#line default
#line hidden
            EndContext();
            BeginContext(806, 59, true);
            WriteLiteral("\r\n                        </p>\r\n                        <p>");
            EndContext();
            BeginContext(866, 43, false);
#line 23 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                      Write(Html.DisplayFor(modelItem => item.overview));

#line default
#line hidden
            EndContext();
            BeginContext(909, 58, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 26 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(984, 1031, true);
            WriteLiteral(@"            <a class=""prev"" onclick=""plusSlides(-1)"">&#10094;</a>
            <a class=""next"" onclick=""plusSlides(1)"">&#10095;</a>
        </div>
        
    </div>

    <!--end of the first division.  -->


    <div class=""second-div"">
        <div>
            <h3>IN THEATRE</h3>
            <!-- Nav tabs -->
            <ul class=""nav nav-tabs"" role=""tablist"">
                <li role=""presentation"" class="".nav-link.active""><a href=""#upcome"" aria-controls=""upcome"" role=""tab"" data-toggle=""tab"">UPCOMING</a></li>
                <li role=""presentation""><a href=""#trending"" aria-controls=""trending"" role=""tab"" data-toggle=""tab"">TRENDING</a></li>
                <li role=""presentation""><a href=""#popular"" aria-controls=""popular"" role=""tab"" data-toggle=""tab"">POPULAR</a></li>
            </ul>

            <!-- Tab panes -->
            <div class=""tab-content"">
                <div role=""tabpanel"" class=""tab-pane active"" id=""upcome"">
                    <div class=""tabs-container container-fl");
            WriteLiteral("uid\">\r\n");
            EndContext();
#line 51 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                         foreach (var upcome in Model.Upcome.results.OrderByDescending(res => res.release_date).Take(6))
                        {

#line default
#line hidden
            BeginContext(2164, 101, true);
            WriteLiteral("                            <div class=\"tabs\">\r\n                                <img class=\"tabs-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2265, "\"", 2292, 1);
#line 54 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 2271, upcome.imageFullpath, 2271, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2293, "\"", 2312, 1);
#line 54 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 2299, upcome.title, 2299, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2313, 102, true);
            WriteLiteral(" />\r\n                                <div class=\"tabs-text\">\r\n                                    <p> ");
            EndContext();
            BeginContext(2416, 42, false);
#line 56 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => upcome.title));

#line default
#line hidden
            EndContext();
            BeginContext(2458, 54, true);
            WriteLiteral("</p>\r\n                                    <p> &#11088;");
            EndContext();
            BeginContext(2513, 49, false);
#line 57 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => upcome.vote_average));

#line default
#line hidden
            EndContext();
            BeginContext(2562, 87, true);
            WriteLiteral(" / 10</p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 60 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2676, 172, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div role=\"tabpanel\" class=\"tab-pane\" id=\"trending\">\r\n                    <div class=\"tabs-container\">\r\n");
            EndContext();
#line 65 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                         foreach (var trend in Model.Trend.results.Take(6))
                        {

#line default
#line hidden
            BeginContext(2952, 101, true);
            WriteLiteral("                            <div class=\"tabs\">\r\n                                <img class=\"tabs-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3053, "\"", 3079, 1);
#line 68 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 3059, trend.imageFullpath, 3059, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3080, "\"", 3098, 1);
#line 68 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 3086, trend.title, 3086, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3099, 102, true);
            WriteLiteral(" />\r\n                                <div class=\"tabs-text\">\r\n                                    <p> ");
            EndContext();
            BeginContext(3202, 41, false);
#line 70 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => trend.title));

#line default
#line hidden
            EndContext();
            BeginContext(3243, 54, true);
            WriteLiteral("</p>\r\n                                    <p> &#11088;");
            EndContext();
            BeginContext(3298, 48, false);
#line 71 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => trend.vote_average));

#line default
#line hidden
            EndContext();
            BeginContext(3346, 87, true);
            WriteLiteral(" / 10</p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 74 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3460, 171, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div role=\"tabpanel\" class=\"tab-pane\" id=\"popular\">\r\n                    <div class=\"tabs-container\">\r\n");
            EndContext();
#line 79 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                         foreach (var popular in Model.Index.results.Take(6))
                        {

#line default
#line hidden
            BeginContext(3737, 101, true);
            WriteLiteral("                            <div class=\"tabs\">\r\n                                <img class=\"tabs-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3838, "\"", 3866, 1);
#line 82 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 3844, popular.imageFullpath, 3844, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3867, "\"", 3887, 1);
#line 82 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 3873, popular.title, 3873, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3888, 102, true);
            WriteLiteral(" />\r\n                                <div class=\"tabs-text\">\r\n                                    <p> ");
            EndContext();
            BeginContext(3991, 43, false);
#line 84 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => popular.title));

#line default
#line hidden
            EndContext();
            BeginContext(4034, 54, true);
            WriteLiteral("</p>\r\n                                    <p> &#11088;");
            EndContext();
            BeginContext(4089, 50, false);
#line 85 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => popular.vote_average));

#line default
#line hidden
            EndContext();
            BeginContext(4139, 87, true);
            WriteLiteral(" / 10</p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 88 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4253, 859, true);
            WriteLiteral(@"                    </div>
                </div>

            </div>
        </div>
        <div>
            <h3>TV SHOWS</h3>
            <!-- Nav tabs -->
            <ul class=""nav nav-tabs"" role=""tablist"">
                <li role=""presentation"" class=""active""><a href=""#populartv"" aria-controls=""populartv"" role=""tab"" data-toggle=""tab""> POPULAR </a></li>
                <li role=""presentation""><a href=""#topratedtv"" aria-controls=""topratedtv"" role=""tab"" data-toggle=""tab"">TOP RATED</a></li>
                <li role=""presentation""><a href=""#onairtv"" aria-controls=""onairtv"" role=""tab"" data-toggle=""tab"">ON AIR</a></li>
            </ul>

            <!-- Tab panes -->
            <div class=""tab-content"">
                <div role=""tabpanel"" class=""tab-pane active"" id=""populartv"">
                    <div class=""tabs-container"">
");
            EndContext();
#line 107 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                         foreach (var poptv in Model.TvShow.results.Take(6))
                        {

#line default
#line hidden
            BeginContext(5217, 101, true);
            WriteLiteral("                            <div class=\"tabs\">\r\n                                <img class=\"tabs-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5318, "\"", 5344, 1);
#line 110 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 5324, poptv.fullImagePath, 5324, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5345, "\"", 5362, 1);
#line 110 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 5351, poptv.name, 5351, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5363, 102, true);
            WriteLiteral(" />\r\n                                <div class=\"tabs-text\">\r\n                                    <p> ");
            EndContext();
            BeginContext(5466, 40, false);
#line 112 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => poptv.name));

#line default
#line hidden
            EndContext();
            BeginContext(5506, 54, true);
            WriteLiteral("</p>\r\n                                    <p> &#11088;");
            EndContext();
            BeginContext(5561, 48, false);
#line 113 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => poptv.vote_average));

#line default
#line hidden
            EndContext();
            BeginContext(5609, 87, true);
            WriteLiteral(" / 10</p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 116 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(5723, 174, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div role=\"tabpanel\" class=\"tab-pane\" id=\"topratedtv\">\r\n                    <div class=\"tabs-container\">\r\n");
            EndContext();
#line 121 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                         foreach (var toprate in Model.TopRated.results.Take(6))
                        {

#line default
#line hidden
            BeginContext(6006, 101, true);
            WriteLiteral("                            <div class=\"tabs\">\r\n                                <img class=\"tabs-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6107, "\"", 6135, 1);
#line 124 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 6113, toprate.fullImagePath, 6113, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6136, "\"", 6155, 1);
#line 124 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 6142, toprate.name, 6142, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6156, 102, true);
            WriteLiteral(" />\r\n                                <div class=\"tabs-text\">\r\n                                    <p> ");
            EndContext();
            BeginContext(6259, 42, false);
#line 126 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => toprate.name));

#line default
#line hidden
            EndContext();
            BeginContext(6301, 54, true);
            WriteLiteral("</p>\r\n                                    <p> &#11088;");
            EndContext();
            BeginContext(6356, 50, false);
#line 127 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => toprate.vote_average));

#line default
#line hidden
            EndContext();
            BeginContext(6406, 87, true);
            WriteLiteral(" / 10</p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 130 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(6520, 171, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div role=\"tabpanel\" class=\"tab-pane\" id=\"onairtv\">\r\n                    <div class=\"tabs-container\">\r\n");
            EndContext();
#line 135 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                         foreach (var onair in Model.showOnAir.results.Take(6))
                        {

#line default
#line hidden
            BeginContext(6799, 101, true);
            WriteLiteral("                            <div class=\"tabs\">\r\n                                <img class=\"tabs-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6900, "\"", 6926, 1);
#line 138 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 6906, onair.fullImagePath, 6906, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6927, "\"", 6944, 1);
#line 138 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 6933, onair.name, 6933, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6945, 102, true);
            WriteLiteral(" />\r\n                                <div class=\"tabs-text\">\r\n                                    <p> ");
            EndContext();
            BeginContext(7048, 40, false);
#line 140 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => onair.name));

#line default
#line hidden
            EndContext();
            BeginContext(7088, 54, true);
            WriteLiteral("</p>\r\n                                    <p> &#11088;");
            EndContext();
            BeginContext(7143, 48, false);
#line 141 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => onair.vote_average));

#line default
#line hidden
            EndContext();
            BeginContext(7191, 87, true);
            WriteLiteral(" / 10</p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 144 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(7305, 233, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <div id=\"playlist-videos\" onload=\"loadVideo()\">\r\n            <h3>IN THEATRE</h3>\r\n                <section>\r\n                    \r\n\r\n");
            EndContext();
#line 156 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                     foreach (var video in Model.youtube.items.Take(3))
                    {

#line default
#line hidden
            BeginContext(7634, 161, true);
            WriteLiteral("                        <div class=\"embed-responsive embed-responsive-21by9\" width=\"621\" height=\"400\">\r\n                    <iframe class=\"embed-responsive-item\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 7795, "\"", 7835, 1);
#line 159 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 7801, video.snippet.resourceId.videoURL, 7801, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7836, 287, true);
            WriteLiteral(@" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
                </div>
                        <article id=""video-item"">
                            <div class=""item-div"">
                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 8123, "\"", 8163, 1);
#line 163 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 8129, video.snippet.thumbnails.high.url, 8129, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8164, 22, true);
            WriteLiteral(" class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 8186, "\"", 8212, 1);
#line 163 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
WriteAttributeValue("", 8192, video.snippet.title, 8192, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8213, 83, true);
            WriteLiteral(" width=\"100\" height=\"57\" />\r\n                                <p class=\"item-title\">");
            EndContext();
            BeginContext(8297, 19, false);
#line 164 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"
                                                 Write(video.snippet.title);

#line default
#line hidden
            EndContext();
            BeginContext(8316, 78, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </article>\r\n");
            EndContext();
#line 167 "C:\Users\Kevwe\source\repos\MoviesReviewApp\Pages\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(8419, 746, true);
            WriteLiteral(@"                </section>


        </div>
    </div>



</div>
<script>
    var slideIndex = 1;
    showSlides(slideIndex);

    function plusSlides(n) {
        showSlides(slideIndex += n);
    }

    function currentSlide(n) {
        showSlides(slideIndex = n);
    }

    function showSlides(n) {
        var i;
        var slides = document.getElementsByClassName(""mySlides"");
        if (n > slides.length) { slideIndex = 1 }
        if (n < 1) { slideIndex = slides.length }
        for (i = 0; i < slides.length; i++) {
            slides[i].style.display = ""none"";
        }
        slides[slideIndex - 1].style.display = ""block"";
        dots[slideIndex - 1].className += "" active"";
    }

</script>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
