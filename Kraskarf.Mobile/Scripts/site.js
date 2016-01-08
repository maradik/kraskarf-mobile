var initSmoothScroll = function () {
    $('a.smooth').click(function() {
        $('html, body').animate({
            scrollTop: $($.attr(this, 'href')).offset().top - 80
        }, 500);
    });
}

initSmoothScroll();