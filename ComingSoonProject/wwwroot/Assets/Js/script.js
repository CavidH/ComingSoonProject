(function($) {
    "use strict";
    // var end = $('.popup').attr("data-target");
    $.fn.aksCountDown = function(options) {
        const aks = $(this);
        var settings = $.extend({
                endTime: "",
                refresh: 1000,
                onEnd: function() {}
            },
            options
        );
        return this.each(function(i) {
            function endTimeCheck(d1, d2) {
                return (
                    d1.getFullYear() === d2.getFullYear() &&
                    d1.getMonth() === d2.getMonth() &&
                    d1.getDate() === d2.getDate()
                );
            }

            function countTimer() {
                var endTime = new Date(settings.endTime);
                endTime = Date.parse(endTime) / 1000;

                var now = new Date();
                now = Date.parse(now) / 1000;

                var timeLeft = endTime - now;

                var days = Math.floor(timeLeft / 86400);
                var hours = Math.floor((timeLeft - days * 86400) / 3600);
                var minutes = Math.floor((timeLeft - days * 86400 - hours * 3600) / 60);
                var seconds = Math.floor(
                    timeLeft - days * 86400 - hours * 3600 - minutes * 60
                );

                if (hours < "10") {
                    hours = "0" + hours;
                }
                if (minutes < "10") {
                    minutes = "0" + minutes;
                }
                if (seconds < "10") {
                    seconds = "0" + seconds;
                }

                $(aks).find("[data-days]").html(days);
                $(aks).find("[data-hours]").html(hours);
                $(aks).find("[data-minutes]").html(minutes);
                $(aks).find("[data-seconds]").html(seconds);
            }
            var now = new Date();
            var endTime = new Date(settings.endTime);

            if (endTimeCheck(now, endTime) === true) {
                settings.onEnd.call(aks);
            } else {
                setInterval(function() {
                    countTimer();
                }, settings.refresh);
            }
        });
    };
})(jQuery);

$("#timer").aksCountDown({
    endTime: "15 June 2022 9:56:00 GMT+01:00",
    onEnd: function() {
        $(this).html('<div class="timer-end">Finished Time</div>');
    }
});