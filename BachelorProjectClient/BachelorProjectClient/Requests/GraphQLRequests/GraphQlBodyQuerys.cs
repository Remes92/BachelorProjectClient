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
                    "productsAndTypes(lower:" + lowerLimit + ",upper:" + upperLimit + "){" +
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
                    "products(lower:" + lowerLimit + ",upper:" + upperLimit + "){" +
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
                    "productsAndTypesAndCompanys(lower:" + lowerLimit + ",upper:" + upperLimit + "){" +
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
                            "productId, " +
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
                            "product_Max," +
                            "product_Name," +
                            "product_Price2," +
                            "product_Parameters," +
                            "product_NoticeLevel," +
                            "product_Premium," +
                            "product_Product," +
                            "product_Version," +
                            "product_Level," +
                            "product_ApprovedDate," +
                            "resellerId," +
                            "product_Retention," +
                            "product_Rule1," +
                            "product_Rule2," +
                            "product_Rule3," +
                            "product_Method," +
                            "product_StartDate," +
                            "product_Status," +
                            "product_StatusString," +
                            "product_PhoneNo," +
                            "product_URL," +
                            "productType, " +
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
        public static GraphQLQuery CreateGraphQLBodyTestCase14(int id)
        {
            return new GraphQLQuery
            {
                Query = "{" +
                        "product(id:" + id + "){" +
                            "productId, " +
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
                            "product_Max," +
                            "product_Name," +
                            "product_Price2," +
                            "product_Parameters," +
                            "product_NoticeLevel," +
                            "product_Premium," +
                            "product_Product," +
                            "product_Version," +
                            "product_Level," +
                            "product_ApprovedDate," +
                            "resellerId," +
                            "product_Retention," +
                            "product_Rule1," +
                            "product_Rule2," +
                            "product_Rule3," +
                            "product_Method," +
                            "product_StartDate," +
                            "product_Status," +
                            "product_StatusString," +
                            "product_PhoneNo," +
                            "product_URL," +
                            "productType, " +
                        "}" +
                    "}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase15(int id)
        {
            return new GraphQLQuery
            {
                Query = "{" +
                        "productAndTypeAndCompany(id:" + id + "){" +
                            "productId, " +
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
                            "product_Max," +
                            "product_Name," +
                            "product_Price2," +
                            "product_Parameters," +
                            "product_NoticeLevel," +
                            "product_Premium," +
                            "product_Product," +
                            "product_Version," +
                            "product_Level," +
                            "product_ApprovedDate," +
                            "resellerId," +
                            "product_Retention," +
                            "product_Rule1," +
                            "product_Rule2," +
                            "product_Rule3," +
                            "product_Method," +
                            "product_StartDate," +
                            "product_Status," +
                            "product_StatusString," +
                            "product_PhoneNo," +
                            "product_URL," +
                            "productType, " +
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
        public static GraphQLQuery CreateGraphQLBodyTestCase16(int lowerLimit, int upperLimit)
        {
            return new GraphQLQuery
            {
                Query = "{" +
                        "productsAndTypes(lower:" + lowerLimit + ",upper:" + upperLimit + "){" +
                            "productId, " +
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
                            "product_Max," +
                            "product_Name," +
                            "product_Price2," +
                            "product_Parameters," +
                            "product_NoticeLevel," +
                            "product_Premium," +
                            "product_Product," +
                            "product_Version," +
                            "product_Level," +
                            "product_ApprovedDate," +
                            "resellerId," +
                            "product_Retention," +
                            "product_Rule1," +
                            "product_Rule2," +
                            "product_Rule3," +
                            "product_Method," +
                            "product_StartDate," +
                            "product_Status," +
                            "product_StatusString," +
                            "product_PhoneNo," +
                            "product_URL," +
                            "productType, " +
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
        public static GraphQLQuery CreateGraphQLBodyTestCase17(int lowerLimit, int upperLimit)
        {
            return new GraphQLQuery
            {
                Query = "{" +
                        "products(lower:" + lowerLimit + ",upper:" + upperLimit + "){" +
                            "productId, " +
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
                            "product_Max," +
                            "product_Name," +
                            "product_Price2," +
                            "product_Parameters," +
                            "product_NoticeLevel," +
                            "product_Premium," +
                            "product_Product," +
                            "product_Version," +
                            "product_Level," +
                            "product_ApprovedDate," +
                            "resellerId," +
                            "product_Retention," +
                            "product_Rule1," +
                            "product_Rule2," +
                            "product_Rule3," +
                            "product_Method," +
                            "product_StartDate," +
                            "product_Status," +
                            "product_StatusString," +
                            "product_PhoneNo," +
                            "product_URL," +
                            "productType, " +
                    "}" +
                "}"
            };
        }
        public static GraphQLQuery CreateGraphQLBodyTestCase18(int lowerLimit, int upperLimit)
        {
            return new GraphQLQuery
            {
                Query = "{" +
                        "productsAndTypesAndCompanys(lower:" + lowerLimit + ",upper:" + upperLimit + "){" +
                            "productId, " +
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
                            "product_Max," +
                            "product_Name," +
                            "product_Price2," +
                            "product_Parameters," +
                            "product_NoticeLevel," +
                            "product_Premium," +
                            "product_Product," +
                            "product_Version," +
                            "product_Level," +
                            "product_ApprovedDate," +
                            "resellerId," +
                            "product_Retention," +
                            "product_Rule1," +
                            "product_Rule2," +
                            "product_Rule3," +
                            "product_Method," +
                            "product_StartDate," +
                            "product_Status," +
                            "product_StatusString," +
                            "product_PhoneNo," +
                            "product_URL," +
                            "productType, " +
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
    }
}
