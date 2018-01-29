var productController = function () {
    this.initialize = function () {
        loadData();
        registerEvents();
    }

    function registerEvents() {
        $('#ddlShowPage').on('change', function () {
            app.configs.pageSize = $(this).val();
            app.configs.pageIndex = 1;
            loadData(true);
        });

        $('#btnSearch').on('click', function () {
            loadData(true);
        });

    }

    function loadData(isPageChanged) {
        app.startLoading();
        var template = $('#table-template').html();
        var render = '';
        $.ajax({
            url: '/admin/product/getallpaging',
            type: 'GET',
            data: {
                categoryId: null,
                keyword: $('#txtKeyword').val(),
                page: app.configs.pageIndex,
                pageSize: app.configs.pageSize
            },
            dataType: 'json',
            success: function (res) {
                $.each(res.Results, function (index, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Image: item.Image == null ? '' : '<img src="' + item.Image + '" width="120" />',
                        Name: item.Name,
                        CategoryName: item.ProductCategory.Name,
                        Price: app.formatNumber(item.Price, 0),
                        CreatedDate: app.dateTimeFormatJson(item.DateCreated),
                        Status: app.getStatus(item.Status)
                    });
                });
                if (render != '') {
                    $('#tbl-content').html(render);
                    $('#lblTotalRecords').text(res.RowCount);
                    $('#lblFrom').text(res.FirstRowOnPage);
                    $('#lblTo').text(res.LastRowOnPage);
                    wrapPaging(res.RowCount, function () {
                        loadData();
                    }, isPageChanged);
                }
                app.stopLoading();
            },
            error: function (status) {
                console.log(status);
                app.notify('Cannot load data', 'error');
                app.stopLoading();
            }
        });
    }

    function wrapPaging(recordCount, callback, changePageSize) {
        var totalSize = Math.ceil(recordCount / app.configs.pageSize);
        if ($('#paginationUL a').length === 0 || changePageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData('twbs-pagination');
            $('#paginationUL').unbind('page');
        }

        $('#paginationUL').twbsPagination({
            totalPages: totalSize,
            visiblePages: 7,
            first: 'Đầu',
            prev: '«',
            next: '»',
            last: 'Cuối',
            onPageClick: function (event, p) {
                app.configs.pageIndex = p;
                setTimeout(callback(), 200);
            }
        });
    }
}