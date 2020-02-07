USE `test`;
DROP procedure IF EXISTS `customersDelete`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `customersDelete`(
  deleteId int(11)
)
BEGIN
 DELETE FROM customers WHERE id = deleteId;
END$$

DELIMITER ;