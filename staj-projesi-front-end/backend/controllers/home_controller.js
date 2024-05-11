
const showHomePage = (req,res,next) => {
    res.render('home', { layout: 'layout/home_layout'});
}


module.exports = {
    showHomePage
}