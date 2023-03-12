var user = {
    init: function () {
        user.registerEvent()
    },
    registerEvent: function () {
        $('.detail').off('click').on('click', (e) => {
            e.preventDefault()
            $ajax.({
                url: "Student/Detail",
                data:
            })
        })
    }
}

user.init()