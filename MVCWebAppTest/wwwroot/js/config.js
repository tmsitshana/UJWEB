var config = {
    serverPath: GetPath()
}

function GetPath() {
    if (location.toString().indexOf("localhost") === -1) {
        return "/MVCWebAppTest/";
    }
    else {
        return "https://localhost:7284/";
    }

}