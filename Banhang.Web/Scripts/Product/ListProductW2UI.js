var product = {
    init: function () {
        $('#data-content').w2grid({
            name: 'grid',
            show: {
                toolbar: true,
                footer: true,
                toolbarAdd: true,
                toolbarDelete: true,
                toolbarSave: true,
                toolbarEdit: true
            },
            columns: [
                { field: 'HanghoaId', caption: 'Mã số', size: '30%', sortable: true },
                { field: 'TenHanghoa', caption: 'Tên', size: '30%', sortable: true },
                { field: 'GiaBan', caption: 'Giá bán', size: '40%', sortable: true },
                { field: 'NhomHanghoaId', caption: 'Nhóm Hàng', size: '120px', sortable: true },
            ],
            onAdd: function (event) {
                w2alert('add');
            },
            onEdit: function (event) {
                w2alert('edit');
            },
            onDelete: function (event) {
                console.log('delete has default behaviour');
            },
            onSubmit: function (event) {
                w2alert('save');
            },
        });
        $("#GetData").click(product.GetDataClick);
    },
    GetDataClick: function (e) {
        $.ajax({
            url: "/Product/GetListProductDb",
            success: function (data) {
                w2ui['grid'].clear();
                w2ui['grid'].add(data);
            }
        });
    }
};
$(document).ready(product.init);