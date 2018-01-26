var loginController = function () {
    this.initialize = function () {
        registerEvents();
    };

    var registerEvents = function () {
        $('#frmLogin').validate({
            errorClass: 'text-danger',
            ignore : [],
            lang : 'vi',
            rules: {
                txtUsername: { 
                    required: true
                },
                txtPassword: { 
                    required: true
                }
            }
        });

        $('#btnLogin').click(function (e) {
            if($('#frmLogin').valid()){
                e.preventDefault();
                var user = $('#txtUsername').val();
                var pass = $('#txtPassword').val();
                login(user, pass);
            }
        });
    };

    var login = function (user, pass) {
        $.ajax({
            url: '/admin/login/authen',
            type: 'POST',
            data: {
                Username: user,
                Password: pass
            },
            dataType: 'json',
            success: function (res) {
                if (res.Success) {
                    window.location.href = '/admin/home/index';
                } else {
                    app.notify('Đăng nhập thất bại!', 'error');
                }
            }
        });
    };
};