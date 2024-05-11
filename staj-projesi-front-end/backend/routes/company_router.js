const router = require('express').Router();
const companyController = require('../controllers/company_controller');
const errormiddleware = require('../middlewares/error_middleware');

router.post('/addCompany',companyController.addCompany,errormiddleware.dbError);
router.put('/updateCompany/:id', companyController.updateCompany, errormiddleware.dbError)
router.get('/showCompany',companyController.showCompany,errormiddleware.dbError);

module.exports = router;