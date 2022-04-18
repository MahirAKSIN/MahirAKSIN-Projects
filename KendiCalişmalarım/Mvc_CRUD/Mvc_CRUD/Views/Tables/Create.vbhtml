@ModelType Mvc_CRUD.Table
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Ogrenci Ekle</h4>
        <hr />
        <div class="container ">
            <div class="row">
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                <div class="col-6">
                    <div class="form-group">
                        @Html.LabelFor(Function(model) model.OgrId, htmlAttributes:=New With {.class = "control-label col-md-2"})
                        <div class="col-md-10">
                            @Html.EditorFor(Function(model) model.OgrId, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.OgrId, "", New With {.class = "text-danger"})
                        </div>
                    </div>

                    <div class="form-group">
                        @Html.LabelFor(Function(model) model.OgrAd, htmlAttributes:=New With {.class = "control-label col-md-2"})
                        <div class="col-md-10">
                            @Html.EditorFor(Function(model) model.OgrAd, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.OgrAd, "", New With {.class = "text-danger"})
                        </div>
                    </div>
                    <div class="form-group">
                        @Html.LabelFor(Function(model) model.OgrSoyad, htmlAttributes:=New With {.class = "control-label col-md-2"})
                        <div class="col-md-10">
                            @Html.EditorFor(Function(model) model.OgrSoyad, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.OgrSoyad, "", New With {.class = "text-danger"})
                        </div>
                    </div>
                </div>
                <div class="col-6">

                    <div class="form-group">
                        @Html.LabelFor(Function(model) model.OgrMail, htmlAttributes:=New With {.class = "control-label col-md-2"})
                        <div class="col-md-10">
                            @Html.EditorFor(Function(model) model.OgrMail, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.OgrMail, "", New With {.class = "text-danger"})
                        </div>
                    </div>
                    <div class="form-group">
                            @Html.LabelFor(Function(model) model.OgrFotograf, htmlAttributes:= New With { .class = "control-label col-md-2" })
                            <div class="col-md-10">
                                @Html.EditorFor(Function(model) model.OgrFotograf, New With { .htmlAttributes = New With { .class = "form-control" } })
                                @Html.ValidationMessageFor(Function(model) model.OgrFotograf, "", New With { .class = "text-danger" })
                            </div>
                        </div>

                    <div class="form-group">
                        @Html.LabelFor(Function(model) model.OgrAdres, htmlAttributes:=New With {.class = "control-label col-md-2"})
                        <div class="col-md-10">
                            @Html.EditorFor(Function(model) model.OgrAdres, New With {.htmlAttributes = New With {.class = "form-control"}})
                            @Html.ValidationMessageFor(Function(model) model.OgrAdres, "", New With {.class = "text-danger"})
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <input type="submit" value="Create" class="btn btn-default" />
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </div>
End Using
<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
