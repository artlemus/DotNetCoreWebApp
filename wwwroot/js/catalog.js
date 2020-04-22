
function retrieveCatalog() {
    // url: /catalog/getCatalog
    $.ajax({
        url: '/catalog/getCatalog',
        type: 'GET',
        success: res => {
            console.warn("server responded", res);
            // display cars on the html
        },

        error: detail => {
            console.error("Error on request", detail);
        }
    })
}


function init() {
    console.log("Catalog page!")
    // get data 
    retrieveCatalog();
    // hooks events
}
window.onload = init;