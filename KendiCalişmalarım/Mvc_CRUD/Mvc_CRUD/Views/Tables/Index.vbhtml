@ModelType IEnumerable(Of Mvc_CRUD.Table)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Ogrenci Bilgileri</h2>

<p>
    @Html.ActionLink("Yeni Kayit", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.OgrAd)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.OgrSoyad)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.OgrMail)
        </th>
        <th>
                @Html.DisplayNameFor(Function(model) model.OgrFotograf)
            </th>
        <th>

        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.OgrAd)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.OgrSoyad)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.OgrMail)
            </td>
            <td>
                    @Html.DisplayFor(Function(modelItem) item.OgrFotograf)
                </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.OgrAdres)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.OgrId}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.OgrId}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.OgrId})
            </td>
        </tr>
    Next

</table>
