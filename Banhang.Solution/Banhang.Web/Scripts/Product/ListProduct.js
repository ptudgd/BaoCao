var product = {
    init: function () {
        $("#GetData").click(product.GetDataClick);
        product.GetDataClick();
    },
    GetDataClick: function (e) {
        $.ajax({
            url: "/Product/GetListProduct",
            success: product.DrawTable
        });
    },
    DrawTable: function (data) {
        //alert(JSON.stringify(data));
        var htmlString = "<table border=1>";
        $.each(data, function (index, item) {
            htmlString += "<tr>";
            {
                htmlString += "<td>" + item.Maso + "</td>";
                htmlString += "<td>" + item.Ten + "</td>";
                htmlString += "<td>" + item.Giaban + "</td>";
            }
            htmlString += "</tr>";
        });
        htmlString += "</table>";
        $("#data-content").html(htmlString);
    }
};
$(document).ready(product.init);