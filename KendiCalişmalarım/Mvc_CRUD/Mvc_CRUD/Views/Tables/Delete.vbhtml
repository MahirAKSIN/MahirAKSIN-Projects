@ModelType Mvc_CRUD.Table
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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

        <dt>
            @Html.DisplayNameFor(Function(model) model.OgrFotograf)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OgrFotograf)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.OgrAdres)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OgrAdres)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
