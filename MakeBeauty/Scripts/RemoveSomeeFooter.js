function OnLoad() {
    var removeSomeeHostingFooter = false;
    var sommeeHostingIndex = 0;

    var childCount = document.body.childNodes.length;
    for (var i = 0; i < childCount; i++) {
        var index = childCount - i - 1;
        var child = document.body.childNodes[index];

        if (child.lastChild != null && child.lastChild.innerHTML != null) {
            if (child.lastChild.innerHTML == "Web hosting by Somee.com") {
                removeSomeeHostingFooter = true;
                sommeeHostingIndex = index;
            }
        }
    }

    if (removeSomeeHostingFooter) {
        for (var i = sommeeHostingIndex; i < childCount; i++) {
            document.body.removeChild(document.body.lastChild);
        }
    }
}