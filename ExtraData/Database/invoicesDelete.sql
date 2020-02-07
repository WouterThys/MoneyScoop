USE `test`;
DROP procedure IF EXISTS `invoicesDelete`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicesDelete`(
  deleteId int(11)
)
BEGIN
 DELETE FROM invoices WHERE id = deleteId;
END$$

DELIMITER ;