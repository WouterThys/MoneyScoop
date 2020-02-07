USE test;USE `test`;
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
USE `test`;
DROP procedure IF EXISTS `customersSelectAll`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `customersSelectAll`()
BEGIN

	SELECT * FROM customers;

END$$
DELIMITER ;
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
USE `test`;
DROP procedure IF EXISTS `invoicelinesDelete`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicelinesDelete`(
  deleteId int(11)
)
BEGIN
 DELETE FROM invoicelines WHERE id = deleteId;
END$$

DELIMITER ;
USE `test`;
DROP procedure IF EXISTS `invoicelinesInsert`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicelinesInsert`(
  code varchar (45),
  description varchar (255),
  info varchar (1023),
  invoiceId int (11),
  dateCreated timestamp ,
  unitPrice decimal ,
  multiplier int (11),
  showUnitPrice tinyint (4),
  showDate tinyint (4),
  OUT lid int
)
BEGIN
  INSERT INTO invoicelines(	
	code,
	description,
	info,
	invoiceId,
	dateCreated,
	unitPrice,
	multiplier,
	showUnitPrice,
	showDate,
	lastModified)
  VALUES(	
	code,
	description,
	info,
	invoiceId,
	dateCreated,
	unitPrice,
	multiplier,
	showUnitPrice,
	showDate,
	now());
  SET lid = last_insert_id();
END$$

DELIMITER ;
USE `test`;
DROP procedure IF EXISTS `invoicelinesSelectAll`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicelinesSelectAll`()
BEGIN

	SELECT * FROM invoicelines;

END$$
DELIMITER ;
USE `test`;
DROP procedure IF EXISTS `invoicelinesUpdate`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicelinesUpdate`(
  code varchar (45),
  description varchar (255),
  info varchar (1023),
  invoiceId int (11),
  dateCreated timestamp ,
  unitPrice decimal ,
  multiplier int (11),
  showUnitPrice tinyint (4),
  showDate tinyint (4),
  updateId int
)
BEGIN
  UPDATE
	invoicelines
  SET	
	code = code,
	description = description,
	info = info,
	invoiceId = invoiceId,
	dateCreated = dateCreated,
	unitPrice = unitPrice,
	multiplier = multiplier,
	showUnitPrice = showUnitPrice,
	showDate = showDate,
	lastModified = current_timestamp()
  WHERE
	id = updateId;
END$$

DELIMITER ;
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
USE `test`;
DROP procedure IF EXISTS `invoicesInsert`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicesInsert`(
  code varchar (45),
  description varchar (255),
  info varchar (1023),
  dateCreated timestamp ,
  dateSend timestamp ,
  datePayed timestamp ,
  vat int (11),
  customerId int (11),
  OUT lid int
)
BEGIN
  INSERT INTO invoices(	
	code,
	description,
	info,
	dateCreated,
	dateSend,
	datePayed,
	vat,
	customerId,
	lastModified)
  VALUES(	
	code,
	description,
	info,
	dateCreated,
	dateSend,
	datePayed,
	vat,
	customerId,
	now());
  SET lid = last_insert_id();
END$$

DELIMITER ;
USE `test`;
DROP procedure IF EXISTS `invoicesSelectAll`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicesSelectAll`()
BEGIN

	SELECT * FROM invoices;

END$$
DELIMITER ;
USE `test`;
DROP procedure IF EXISTS `invoicesUpdate`;

DELIMITER $$
USE `test`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `invoicesUpdate`(
  code varchar (45),
  description varchar (255),
  info varchar (1023),
  dateCreated timestamp ,
  dateSend timestamp ,
  datePayed timestamp ,
  vat int (11),
  customerId int (11),
  updateId int
)
BEGIN
  UPDATE
	invoices
  SET	
	code = code,
	description = description,
	info = info,
	dateCreated = dateCreated,
	dateSend = dateSend,
	datePayed = datePayed,
	vat = vat,
	customerId = customerId,
	lastModified = current_timestamp()
  WHERE
	id = updateId;
END$$

DELIMITER ;
