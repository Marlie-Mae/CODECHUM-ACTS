-- Table structure for table `user_details`--

IF OBJECT_ID('user_details', 'U') IS NOT NULL
DROP TABLE user_details;

CREATE TABLE user_details (
  user_id int IDENTITY(1,1) PRIMARY KEY,
  username nvarchar(255) NULL,
  first_name nvarchar(50) NULL,
  last_name nvarchar(50) NULL,
  gender nvarchar(10) NULL,
  password nvarchar(50) NULL,
  status tinyint NULL
);

-- Dumping data for table `user_details`--

INSER
('brooks80', 'morgan', 'maria', 'Female', 'aa736a35dc15934d67c0a999dccff8f6', 1),
('morgan65', 'paul', 'miller', 'Female', 'a28dca31f5aa5792e1cefd1dfd098569', 1);

-- Selecting data from the table
SELECT * FROM user_details;
