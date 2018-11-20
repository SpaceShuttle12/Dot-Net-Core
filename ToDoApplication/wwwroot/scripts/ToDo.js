var toDo = {
    siteRoot: ""
}
var $app = "";
var ToDo = {
    init: function (Resources, siteRoot) {
        toDo.ValidateTaskName = Resources[0].ValidateTaskName;
        toDo.ValidateTaskName1 = Resources[0].ValidateTaskName1;
        toDo.ValidateTaskDescription = Resources[0].ValidateTaskDescription;
        toDo.ValidateTaskDescription1 = Resources[0].ValidateTaskDescription1;
        toDo.ValidateTaskStatus = Resources[0].ValidateTaskStatus;
        toDo.ConfirmationMessage = Resources[0].confirmationMessage;
        toDo.siteRoot = siteRoot;
        this.addTask();
        this.updateTask();
        this.deleteTask();
        this.onTaskDescriptionChange();
        this.onTaskNameChange();
        this.onTaskStatusChange();
        $app = this;
    },
    addTask: function () {
        $(document).on("submit", ".addForm", function (e) {
            e.preventDefault();
            if ($app.validateForm()) {
                let url = toDo.siteRoot + "/ToDo/AddTask";
                let data = $(".addForm").serialize();
                $app.ajaxCall(url, data, "A");
            }
            else {
                return false;
            }
        })
    },
    updateTask: function () {
        $(document).on("submit", ".edditForm", function (e) {
            e.preventDefault();
            if ($app.validateForm()) {
                let url = toDo.siteRoot + "/ToDo/EditTask";
                let data = $(".edditForm").serialize();
                $app.ajaxCall(url, data, "E");
            }
            else {
                return false;
            }
        })
    },
    deleteTask: function () {
        $(document).on("click", ".deleteTask", function (e) {
            e.preventDefault();
            let url = $(this).href();
            let id = $(this).data("id");
            if (confirm(toDo.ConfirmationMessage)) {
                $app.ajaxCall(url, id, "D");
            }
        })
    },
    validateForm: function () {
        let validation = true;
        if (!$app.validateTaskName()) {
            validation = false;
        }
        if (!$app.validateTaskDescription()) {
            validation = false;
        }
        if (!$app.validateTaskStatus()) {
            validation = false;
        }
        return validation;
    },
    validateTaskName: function () {
        let value = $("#TaskName").val();
        if (value === "") {
            $("#validateName").html(toDo.ValidateTaskName)
            return false;
        } else {
            if (value.length < 5) {
                $("#validateName").html(toDo.ValidateTaskName1)
                return false;
            } else {
                // toDo.isValidated = true;
                $("#validateName").html("");
                return true;
            }
        }
        return toDo.isValidated;
    },
    validateTaskDescription: function () {
        let value = $("#TaskDescription").val();
        if (value === "") {
            $("#validateDescription").html(toDo.ValidateTaskDescription)
            return false;
        } else {
            if (value.length < 10) {
                $("#validateDescription").html(toDo.ValidateTaskDescription1)
                return false;
            }
            else {

                $("#validateDescription").html("");
                return true;
            }
        }
        return toDo.isValidated;
    },
    validateTaskStatus: function () {
        let value = $("#TaskStatus").val();
        if (value == "0") {
            $("#validateStatus").html(toDo.ValidateTaskStatus)
            return false;
        } else {
            $("#validateStatus").html("");
            return true;
        }
        return toDo.isValidated;
    },
    onTaskNameChange: function () {
        $(document).on("change", "#TaskName", function (e) {
            if ($app.validateTaskName()) {
                return true;
            } else {
                return false
            }
        })
    },
    onTaskDescriptionChange: function () {
        $(document).on("change", "#TaskDescription", function (e) {
            if ($app.validateTaskDescription()) {
                return true;
            } else {
                return false
            }
        })
    },
    onTaskStatusChange: function () {
        $(document).on("change", "#TaskStatus", function (e) {
            if ($app.validateTaskStatus()) {
                return true;
            } else {
                return false
            }
        });
    },
    ajaxCall: function (url, data, action) {
        let ajaxData = {};
        if (action == "D") {
            ajaxData = { id: data }
        } else {
            ajaxData = data
        }
        $.ajax({
            url: url,
            method: "POST",
            data: ajaxData,
            success: function (data) {
                if (data.success) {
                    toastr.success(data.message);
                    setTimeout(function (e) {
                        location.href = toDo.siteRoot + "/ToDo/Index"
                    }, 5000);
                } else {
                    toastr.warning(data.message);
                }
            },
            error: function (a, b, c) {
                console.log(a);
                console.log(b);
                console.log(c);
            }

        })
    }
}