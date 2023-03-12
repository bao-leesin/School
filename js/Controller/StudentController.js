var user = {
    init: function () {
        user.registerEvent()
    },
    registerEvent: function () {
        $('.detail').off('click').on('click', (e) => {
            e.preventDefault()
            $ajax.({
                url: "Student/Detail",
                data: { id: $.(this).data('studentId') },
                type: "json",
                contentType: "application/json;charset = utf-8",
                success: (response) => {

                }
            })
        })
    }
}

user.init()