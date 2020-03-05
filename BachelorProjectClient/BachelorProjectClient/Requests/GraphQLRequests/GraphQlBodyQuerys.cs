using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachelorProjectClient.Requests.GraphQLRequests
{
    public class GraphQlBodyQuerys
    {
        public static GraphQLQuery CreateGraphQLBodyTestCase1(int id)
        {
            return new GraphQLQuery
            {
                Query = "{" +
                        "productAndType(id:"+id+"){" +
                        "    productId," +
                        "    productTypeId," +
                        "    companyId," +
                        "    managerId," +
                        "    adjustedId," +
                        "    product_Comment," +
                        "    productTypeObject {" +
                        "        productTypeId," +
                        "        productType_DescriptionString," +
                        "        productType_KeySellingPoint," +
                        "        productType_Label," +
                        "        productType_Name," +
                        "        productType_Status" +
                        "    }"+
                        "}" +
                    "}"
                };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase2(int id)
        {
            return new GraphQLQuery
            {
                Query = "{" +
                "product(id:"+id+"){" +
                    "productId," +
                    "productTypeId," +
                    "companyId," +
                    "managerId," +
                    "adjustedId," +
                    "product_Comment" +
                "}" +
            "}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase3(int id)
        {
            return new GraphQLQuery
            {
                Query ="{" + 
                        "productAndTypeAndCompany(id"+id+"){" +
                        "    productId," +
                        "    productTypeId," +
                        "    companyId," +
                        "    managerId," +
                        "    adjustedId," +
                        "    product_Comment," +
                        "    productTypeObject {" +
                        "        productTypeId," +
                        "        productType_DescriptionString," +
                        "        productType_KeySellingPoint," +
                        "        productType_Label," +
                        "        productType_Name," +
                        "        productType_Status" +
                        "    }," +
                        "    companyObject {" +
                        "        companyId," +
                        "        company_Name," +
                        "        company_DirectionIn," +
                        "        company_DirectionOut," +
                        "        company_Phone," +
                        "        company_Label" +
                        "    }" +
                        "}" +
                    "}"
                };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase4(int lowerLimit, int upperLimit)
        {
            return new GraphQLQuery
            {
                Query = "{" +
                        "productsAndTypes(lower:" + lowerLimit + ",upper:" + upperLimit + "){" +
                        "productId," +
                        "productTypeId," +
                        "companyId," +
                        "managerId," +
                        "adjustedId," +
                        "product_Comment," +
                        "productTypeObject {" +
                            "productTypeId," +
                            "productType_DescriptionString," +
                            "productType_KeySellingPoint," +
                            "productType_Label," +
                            "productType_Name," +
                            "productType_Status" +
                            "}," +
                        "}" +
                "}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase5(int lowerLimit, int upperLimit)
        {
            return new GraphQLQuery
            {

                Query = "{" +
                        "products(lower:" + lowerLimit + ",upper:" + upperLimit + "){" +
                        "productId," +
                        "productTypeId," +
                        "companyId," +
                        "managerId," +
                        "adjustedId," +
                        "product_Comment," +
                "}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase6(int lowerLimit, int upperLimit)
        {
            return new GraphQLQuery
            {
                Query = "{" +
                        "productsAndTypesAndCompanys(lower:"+lowerLimit+",upper:"+upperLimit+"){" +
                        "productId," +
                        "productTypeId," +
                        "companyId," +
                        "managerId," +
                        "adjustedId," +
                        "product_Comment," +
                        "productTypeObject {" +
                            "productTypeId," +
                            "productType_DescriptionString," +
                            "productType_KeySellingPoint," +
                            "productType_Label," +
                            "productType_Name," +
                            "productType_Status" +
                            "}," +
                        "companyObject {" +
                            "companyId," +
                            "company_Name," +
                            "company_DirectionIn," +
                            "company_DirectionOut," +
                            "company_Phone," +
                            "company_Label" +
                            "}" +
                        "}" +
                "}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase7(int id)
        {
            return new GraphQLQuery
            {

                Query = "{" +
                    "productAndType(id:" + id + "){" +
                        "productId," +
                        "productTypeId," +
                        "companyId," +
                        "managerId," +
                        "administratorId," +
                        "product_Interval," +
                        "adjustedId," +
                        "product_Comment," +
                        "product_Country," +
                        "currency," +
                        "product_Type," +
                        "product_DescriptionString," +
                        "product_EndDate," +
                        "product_ExternalReference," +
                        "product_Price," +
                        "product_Interests," +
                        "product_Category," +
                        "product_CommissionPrice," +
                        "product_SupplierId," +
                        "product_Rating," +
                        "product_Key," +
                        "productTypeObject {" +
                            "productTypeId," +
                            "productType_DescriptionString," +
                            "productType_KeySellingPoint," +
                            "productType_Label," +
                            "productType_Name," +
                            "productType_Status" +
                        "}" +
                    "}" +
                "}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase8(int id)
        {
            return new GraphQLQuery
            {

                Query = "{" +
                    "product(id:" + id + "){" +
                        "productId," +
                        "productTypeId," +
                        "companyId," +
                        "managerId," +
                        "administratorId," +
                        "product_Interval," +
                        "adjustedId," +
                        "product_Comment," +
                        "product_Country," +
                        "currency," +
                        "product_Type," +
                        "product_DescriptionString," +
                        "product_EndDate," +
                        "product_ExternalReference," +
                        "product_Price," +
                        "product_Interests," +
                        "product_Category," +
                        "product_CommissionPrice," +
                        "product_SupplierId," +
                        "product_Rating," +
                        "product_Key," +
                    "}" +
                "}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase9(int id)
        {
            return new GraphQLQuery
            {

                Query = "{" +
                    "productAndTypeAndCompany(id:" + id + "){" +
                        "productId," +
                        "productTypeId," +
                        "companyId," +
                        "managerId," +
                        "administratorId," +
                        "product_Interval," +
                        "adjustedId," +
                        "product_Comment," +
                        "product_Country," +
                        "currency," +
                        "product_Type," +
                        "product_DescriptionString," +
                        "product_EndDate," +
                        "product_ExternalReference," +
                        "product_Price," +
                        "product_Interests," +
                        "product_Category," +
                        "product_CommissionPrice," +
                        "product_SupplierId," +
                        "product_Rating," +
                        "product_Key," +
                        "productTypeObject {" +
                            "productTypeId," +
                            "productType_DescriptionString," +
                            "productType_KeySellingPoint," +
                            "productType_Label," +
                            "productType_Name," +
                            "productType_Status" +
                        "}" +
                         "companyObject {" +
                            "companyId," +
                            "company_Name," +
                            "company_DirectionIn," +
                            "company_DirectionOut," +
                            "company_Phone," +
                            "company_Label," +
                            "company_Slogan" +
                        "}" +
                    "}" +
                "}"
            };
        }


        public static GraphQLQuery CreateGraphQLBodyTestCase10(int lowerLimit,int upperLimit)
        {
            return new GraphQLQuery
            {

                Query = "{" +
                    "productAndType(lower:" + lowerLimit + ",upper:" + upperLimit + "){" +
                        "productId," +
                        "productTypeId," +
                        "companyId," +
                        "managerId," +
                        "administratorId," +
                        "product_Interval," +
                        "adjustedId," +
                        "product_Comment," +
                        "product_Country," +
                        "currency," +
                        "product_Type," +
                        "product_DescriptionString," +
                        "product_EndDate," +
                        "product_ExternalReference," +
                        "product_Price," +
                        "product_Interests," +
                        "product_Category," +
                        "product_CommissionPrice," +
                        "product_SupplierId," +
                        "product_Rating," +
                        "product_Key," +
                        "productTypeObject {" +
                            "productTypeId," +
                            "productType_DescriptionString," +
                            "productType_KeySellingPoint," +
                            "productType_Label," +
                            "productType_Name," +
                            "productType_Status" +
                        "}" +
                    "}" +
                "}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase11(int lowerLimit,int upperLimit)
        {
            return new GraphQLQuery
            {

                Query = "{" +
                    "product(lower:" + lowerLimit + ",upper:" + upperLimit + "){" +
                        "productId," +
                        "productTypeId," +
                        "companyId," +
                        "managerId," +
                        "administratorId," +
                        "product_Interval," +
                        "adjustedId," +
                        "product_Comment," +
                        "product_Country," +
                        "currency," +
                        "product_Type," +
                        "product_DescriptionString," +
                        "product_EndDate," +
                        "product_ExternalReference," +
                        "product_Price," +
                        "product_Interests," +
                        "product_Category," +
                        "product_CommissionPrice," +
                        "product_SupplierId," +
                        "product_Rating," +
                        "product_Key," +
                    "}" +
                "}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase12(int lowerLimit, int upperLimit)
        {
            return new GraphQLQuery
            {

                Query = "{" +
                    "productAndTypeAndCompany(lower:" + lowerLimit + ",upper:" + upperLimit + "){" +
                        "productId," +
                        "productTypeId," +
                        "companyId," +
                        "managerId," +
                        "administratorId," +
                        "product_Interval," +
                        "adjustedId," +
                        "product_Comment," +
                        "product_Country," +
                        "currency," +
                        "product_Type," +
                        "product_DescriptionString," +
                        "product_EndDate," +
                        "product_ExternalReference," +
                        "product_Price," +
                        "product_Interests," +
                        "product_Category," +
                        "product_CommissionPrice," +
                        "product_SupplierId," +
                        "product_Rating," +
                        "product_Key," +
                        "productTypeObject {" +
                            "productTypeId," +
                            "productType_DescriptionString," +
                            "productType_KeySellingPoint," +
                            "productType_Label," +
                            "productType_Name," +
                            "productType_Status" +
                        "}" +
                         "companyObject {" +
                            "companyId," +
                            "company_Name," +
                            "company_DirectionIn," +
                            "company_DirectionOut," +
                            "company_Phone," +
                            "company_Label," +
                            "company_Slogan" +
                        "}" +
                    "}" +
                "}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase13(int id)
        {
            return new GraphQLQuery
            {

                Query = "{" +
                        "productAndType(id:" + id + "){" +
                            "ProductId, " +
                            "ProductTypeId," +
                            "CompanyId," +
                            "ManagerId," +
                            "AdministratorId," +
                            "Product_Interval," +
                            "AdjustedId," +
                            "Product_Comment," +
                            "Product_Country," +
                            "Currency," +
                            "Product_Type," +
                            "Product_DescriptionString," +
                            "Product_EndDate," +
                            "Product_ExternalReference," +
                            "Product_Price," +
                            "Product_Interests," +
                            "Product_Category," +
                            "Product_CommissionPrice," +
                            "Product_SupplierId," +
                            "Product_Rating," +
                            "Product_Key," +
                            "Product_Max," +
                            "Product_Name," +
                            "Product_Price2," +
                            "Product_Parameters," +
                            "Product_NoticeLevel," +
                            "Product_Premium," +
                            "Product_Product," +
                            "Product_Version," +
                            "Product_Level," +
                            "Product_ApprovedDate," +
                            "ResellerId," +
                            "Product_Retention," +
                            "Product_Rule1," +
                            "Product_Rule2," +
                            "Product_Rule3," +
                            "Product_Method," +
                            "Product_StartDate," +
                            "Product_Status," +
                            "Product_StatusString," +
                            "Product_PhoneNo," +
                            "Product_URL," +
                            "ProductType, " +
                            "productTypeObject {" +
                                "productTypeId," +
                                "productType_DescriptionString," +
                                "productType_KeySellingPoint," +
                                "productType_Label," +
                                "productType_Name," +
                                "productType_Status" +
                            "}" +
                        "}" +
                    "}"
            };
            
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase14()
        {
            return new GraphQLQuery
            {
                Query = "{tests{name}}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase15()
        {
            return new GraphQLQuery
            {
                Query = "{tests{name}}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase16()
        {
            return new GraphQLQuery
            {
                Query = "{tests{name}}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase17()
        {
            return new GraphQLQuery
            {
                Query = "{tests{name}}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase18()
        {
            return new GraphQLQuery
            {
                Query = "{tests{name}}"
            };
        }
    }
}
