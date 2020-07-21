window.downloadInspectionPicture = function (p_strServerFilePath, fileName) {
    var link = document.createElement('a');
    link.href = p_strServerFilePath;
    link.download = fileName + ".jpg";
    link.target = '_blank';
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}