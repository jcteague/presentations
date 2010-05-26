$(function() {
    $('.pane').wrap('<div class="wrapper"/><div class="wrapper2"/>');
    $('.delete').click(function() {
        var url = $(this).attr('href');
        var parent = $(this).parents('.pane');
        $.get(url, function() {
            parent.slideUp('slow', function() {
                this.remove();
            });

        });
        return false;
    });



})























/*
$('.pane')
        .wrap('<div class="wrapper"/><div class="wrapper2"/>')
        .addClass('box_round').addClass('box_border').addClass('box_gradient')
        .css('color', '#FCF6CF')
        .find('.delete').css('color', '#FF3030');



$('.delete').click(function() {
        var url = $(this).attr('href');
        var parent = $(this).parents('.pane');
        $.get(url, function() {
            parent.slideUp('slow', function() {
                this.remove();
            });

        });
        return false;
    });



*/
































