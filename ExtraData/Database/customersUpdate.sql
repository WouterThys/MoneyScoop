USE `test`;
DROP procedure IF EXISTS `customersUpdate`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `customersUpdate`(
  code varchar (45),
  description varchar (255),
  info varchar (1023),
  addressLine1 varchar (255),
  addressLine2 varchar (255),
  vatNumber varchar (45),
  email varchar (45),
  phone varchar (45),
  updateId int
)
BEGIN
  UPDATE
	customers
  SET	
	code = code,
	description = description,
	info = info,
	addressLine1 = addressLine1,
	addressLine2 = addressLine2,
	vatNumber = vatNumber,
	email = email,
	phone = phone,
	lastModified = current_timestamp()
  WHERE
	id = updateId;
END$$

DELIMITER ;