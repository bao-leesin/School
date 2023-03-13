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
              
                success: (response) => {

                }
            })
        })
    }
}

user.init()