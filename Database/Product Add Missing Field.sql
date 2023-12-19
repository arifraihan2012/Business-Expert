

/****** Create Field to Product Group ******/

ALTER TABLE [Product Group] ADD [User Account ID] Int NULL ;
ALTER TABLE [Product Group] ADD [Computer ID] Int NULL ;

/****** Create Field to Product category ******/

ALTER TABLE [Product category] ADD [User Account ID] Int NULL ;
ALTER TABLE [Product category] ADD [Computer ID] Int NULL ;

/****** Create Field to Product Subcategory ******/

ALTER TABLE [Product Subcategory] ADD [User Account ID] Int NULL ;
ALTER TABLE [Product Subcategory] ADD [Computer ID] Int NULL ;


/****** Create Field to Chart of Account ID in Bank Information ******/

ALTER TABLE [Bank Information] ADD [Chart Account ID] Int NULL ;