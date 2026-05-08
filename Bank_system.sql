CREATE DATABASE Bank;
Go

 USE Bank;

Go

CREATE TABLE Branch (
    Branch_ID int PRIMARY KEY,
    [Location] varchar(255) NOT NULL,
    BranchName varchar(30) NOT NULL,
    Manager_SSN char(14)
);


CREATE TABLE Employee (
    SSN char(14) PRIMARY KEY,
    Fname varchar(30) NOT NULL,
    Lname varchar(30) NOT NULL,
    Adress varchar(255),
    DOB date,
    Branch_ID int,
    Phone char(11) UNIQUE,
    CONSTRAINT FK_Emp_Branch FOREIGN KEY (Branch_ID)
        REFERENCES Branch(Branch_ID) ON DELETE SET NULL
);



CREATE Table customer (
    SSN char(14) PRIMARY KEY,
    Fname varchar(30) NOT NULL,
    Lname varchar(30) NOT NULL,
    Adress varchar(255),
    DOB date
);

CREATE TABLE Loan (
    ID int PRIMARY KEY,
    Amount DECIMAL(15,2) NOT NULL,
    [Type] varchar(30),
    interest_rate DECIMAL(5, 2) NOT NULL,
    startDate Date Not NULL,
    branch_id int,
    customer_ID char(14),
    FOREIGN KEY (branch_id) REFERENCES Branch (Branch_ID) on delete set null,
    FOREIGN KEY (customer_ID) REFERENCES customer (SSN) 
);


CREATE Table Account (
    AccountID int PRIMARY KEY,
    Balance DECIMAL(15,2) default 0,
    [Type] varchar(30),
    Branch_ID int,
    FOREIGN KEY (Branch_ID) REFERENCES Branch (Branch_ID) on delete set null
);



CREATE Table [Transaction]  (
    ID int PRIMARY KEY,
    Amount DECIMAL(15,2) NOT NULL,
    [Type] varchar(30),
    AccountID int,
    [TxnDate] DATETIME2(0) Not NULL DEFAULT SYSDATETIME(),
    FOREIGN KEY (AccountID) REFERENCES Account (AccountID)
);

CREATE TABLE Login_Credentials (
    username varchar(30),
    customerID char(14),
    password varchar(255) NOT NULL,
    PRIMARY KEY (username, customerID),
    FOREIGN KEY (customerID) REFERENCES customer (SSN)
);


CREATE TABLE Customer_Phone (
    SSN char(14),
    Phone char(11),
    PRIMARY KEY (SSN, Phone),
    FOREIGN KEY (SSN) REFERENCES customer (SSN)
);


CREATE TABLE Owns (
    customerID char(14),
    AccountID int,
    DateOpened DATE NOT NULL DEFAULT CAST(GETDATE() AS DATE),
    PRIMARY KEY (customerID, AccountID),
    FOREIGN KEY (customerID) REFERENCES customer (SSN),
    FOREIGN KEY (AccountID) REFERENCES Account (AccountID)
);


ALTER TABLE Branch
ADD CONSTRAINT FK_Branch_Manager FOREIGN KEY (Manager_SSN)
    REFERENCES Employee(SSN) ON DELETE NO ACTION;

-- 1. Branch (without manager first, we'll update after employees are inserted)
INSERT INTO Branch (Branch_ID, [Location], BranchName, Manager_SSN) VALUES
(1, '123 Nile St, Cairo',       'Cairo Main Branch',  NULL),
(2, '456 Pyramids Rd, Giza',    'Giza Branch',        NULL),
(3, '789 Corniche St, Alex',    'Alexandria Branch',  NULL);


-- 2. Employee
INSERT INTO Employee (SSN, Fname, Lname, Adress, DOB, Branch_ID, Phone) VALUES
('111-11-1111-1', 'Ahmed',   'Hassan',  '10 Tahrir Sq, Cairo',      '1980-03-15', 1, '01011111111'),
('222-22-2222-2', 'Sara',    'Mohamed', '22 Sphinx St, Giza',       '1985-07-22', 2, '01022222222'),
('333-33-3333-3', 'Omar',    'Ali',     '5 Stanley Blvd, Alex',     '1990-11-05', 3, '01033333333'),
('444-44-4444-4', 'Nour',    'Ibrahim', '88 Ramsis St, Cairo',      '1988-01-30', 1, '01044444444');


-- 3. Update Branch managers now that employees exist
UPDATE Branch SET Manager_SSN = '111-11-1111-1' WHERE Branch_ID = 1;
UPDATE Branch SET Manager_SSN = '222-22-2222-2' WHERE Branch_ID = 2;
UPDATE Branch SET Manager_SSN = '333-33-3333-3' WHERE Branch_ID = 3;


-- 4. Customer
INSERT INTO customer (SSN, Fname, Lname, Adress, DOB) VALUES
('555-55-5555-5', 'Mona',    'Khaled',  '3 Garden City, Cairo',     '1992-06-10'),
('666-66-6666-6', 'Karim',   'Samir',   '17 Mohandessin, Giza',     '1987-09-25'),
('777-77-7777-7', 'Layla',   'Farouk',  '9 Gleem St, Alex',         '1995-12-01'),
('888-88-8888-8', 'Youssef', 'Nabil',   '44 Heliopolis, Cairo',     '1983-04-18');


-- 5. Account
INSERT INTO Account (AccountID, Balance, [Type], Branch_ID) VALUES
(1001, 15000.00, 'Savings',  1),
(1002, 32000.50, 'Checking', 2),
(1003,  5000.75, 'Savings',  3),
(1004, 80000.00, 'Business', 1);


-- 6. Loan
INSERT INTO Loan (ID, Amount, [Type], interest_rate, startDate, branch_id, customer_ID) VALUES
(1, 50000.00, 'Personal', 8.50,  '2024-01-15', 1, '555-55-5555-5'),
(2, 200000.00,'Mortgage',  5.25,  '2023-06-01', 2, '666-66-6666-6'),
(3, 30000.00, 'Car',       7.00,  '2024-03-10', 3, '777-77-7777-7');


-- 7. Transaction
INSERT INTO [Transaction] (ID, Amount, [Type], AccountID, TxnDate) VALUES
(1,  500.00,  'Deposit',    1001, '2024-11-01 09:00:00'),
(2,  200.00,  'Withdrawal', 1001, '2024-11-05 14:30:00'),
(3, 1000.00,  'Deposit',    1002, '2024-11-10 11:15:00'),
(4,  750.00,  'Transfer',   1003, '2024-11-12 16:45:00'),
(5, 3000.00,  'Deposit',    1004, '2024-11-15 08:00:00');


-- 8. Login_Credentials
INSERT INTO Login_Credentials (username, customerID, password) VALUES
('mona_k',    '555-55-5555-5', 'hashed_pass_001'),
('karim_s',   '666-66-6666-6', 'hashed_pass_002'),
('layla_f',   '777-77-7777-7', 'hashed_pass_003'),
('youssef_n', '888-88-8888-8', 'hashed_pass_004');


-- 9. Customer_Phone
INSERT INTO Customer_Phone (SSN, Phone) VALUES
('555-55-5555-5', '01055555555'),
('555-55-5555-5', '01055556666'),  -- Mona has 2 phones
('666-66-6666-6', '01066666666'),
('777-77-7777-7', '01077777777'),
('888-88-8888-8', '01088888888');


-- 10. Owns (links customers to accounts)
INSERT INTO Owns (customerID, AccountID, DateOpened) VALUES
('555-55-5555-5', 1001, '2022-01-10'),
('666-66-6666-6', 1002, '2021-05-20'),
('777-77-7777-7', 1003, '2023-03-15'),
('888-88-8888-8', 1004, '2020-11-01'),
('555-55-5555-5', 1004, '2023-08-05');  -- Mona also co-owns account 1004