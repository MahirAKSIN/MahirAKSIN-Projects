@ModelType Mvc_CRUD.Table
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Table</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.OgrAd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OgrAd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.OgrSoyad)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OgrSoyad)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.OgrMail)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OgrMail)
        </dd>

        @*<dt>
            @Html.DisplayNameFor(Function(model) model.OgrFotograf)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OgrFotograf)
        </dd>*@

        <dt>
            @Html.DisplayNameFor(Function(model) model.OgrAdres)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OgrAdres)
        </dd>

    </dl>
</div>
<p>

  
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.OgrId}, New With {.class = "btn btn-success"}) |

    @Html.ActionLink("Back to List", "Index", New With {.class = "btn btn-dark  text-white"})
</p>
<dt>
    <img src="@Model.OgrFotograf"width="50px"height="50px" />
</dt>
