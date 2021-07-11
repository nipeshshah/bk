function LoadDropdown(control, tag) {
    services.getService("load/" + tag, function (response) {
        $(control);
        var html = "<option value=-1>---Select " + GetTitleFromTag(tag) + "---</option>";
        response.forEach(function (item, index) {
            html += "<option value=" + item.value + ">" + item.title + "</option>";
        });
        $(control).html(html);
    });
}

function GetTitleFromTag(tag) {
    if (tag == "city") {
        return "City";
    }
    else if (tag == "idol") {
        return "Idol";
    }
    else if (tag == "trust") {
        return "Trust";
    }
    else if (tag == "yaksh") {
        return "Yaksh";
    }
    else if (tag == "devis") {
        return "Devis";
    }
    else if (tag == "gurumaharaj") {
        return "Guru Maharaj";
    }
    else if (tag == "pagla") {
        return "Pagla";
    }


}