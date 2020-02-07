USE `test`;
DROP procedure IF EXISTS `customersSelectAll`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `customersSelectAll`()
BEGIN

	SELECT * FROM customers;

END$$
DELIMITER ;