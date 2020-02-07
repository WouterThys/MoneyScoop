USE `test`;
DROP procedure IF EXISTS `customersInsert`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `customersInsert`(
  code varchar (45),
  description varchar (255),
  info varchar (1023),
  addressLine1 varchar (255),
  addressLine2 varchar (255),
  vatNumber varchar (45),
  email varchar (45),
  phone varchar (45),
  OUT lid int
)
BEGIN
  INSERT INTO customers(	
	code,
	description,
	info,
	addressLine1,
	addressLine2,
	vatNumber,
	email,
	phone,
	lastModified)
  VALUES(	
	code,
	description,
	info,
	addressLine1,
	addressLine2,
	vatNumber,
	email,
	phone,
	now());
  SET lid = last_insert_id();
END$$

DELIMITER ;