const router = require('express').Router();
const homeController = require('../controllers/home_controller');

router.get('/home',homeController.showHomePage);

module.exports = router;