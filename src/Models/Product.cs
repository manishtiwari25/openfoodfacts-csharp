using System.Text.Json.Serialization;

namespace OpenFoodFacts.DotNet.Wrapper.Models
{
    public class Product
    {
        [JsonPropertyName("images")]
        public Dictionary<string, object> Images { get; set; }

        [JsonPropertyName("ingredients")]
        public List<Ingredient> Ingredients { get; set; }

        [JsonPropertyName("languages_codes")]
        public LanguagesCodes LanguagesCodes { get; set; }

        [JsonPropertyName("nutrient_levels")]
        public NutrientLevels NutrientLevels { get; set; }

        public Nutriments Nutriments { get; set; }

        [JsonPropertyName("selected_images")]
        public SelectedImage SelectedImages { get; set; }

        [JsonPropertyName("sources")]
        public List<Source> Sources { get; set; }

        [JsonPropertyName("additives_n")]
        public int AdditivesN { get; set; }

        [JsonPropertyName("additives_old_n")]
        public int AdditivesOldN { get; set; }

        [JsonPropertyName("additives_original_tags")]
        public List<string> AdditivesOriginalTags { get; set; }

        [JsonPropertyName("additives_old_tags")]
        public List<string> AdditivesOldTags { get; set; }

        [JsonPropertyName("additives_prev_original_tags")]
        public List<string> AdditivesPrevOriginalTags { get; set; }

        [JsonPropertyName("additives_debug_tags")]
        public List<string> AdditivesDebugTags { get; set; }

        [JsonPropertyName("additives_tags")]
        public List<string> AdditivesTags { get; set; }

        [JsonPropertyName("allergens")]
        public List<string> Allergens { get; set; }

        [JsonPropertyName("allergens_from_ingredients")]
        public string AllergensFromIngredients { get; set; }

        [JsonPropertyName("allergens_from_user")]
        public string AllergensFromUser { get; set; }

        [JsonPropertyName("allergens_hierarchy")]
        public List<string> AllergensHierarchy { get; set; }

        [JsonPropertyName("allergens_lc")]
        public string AllergensLc { get; set; }

        [JsonPropertyName("allergens_tags")]
        public List<string> AllergensTags { get; set; }

        [JsonPropertyName("amino_acids_prev_tags")]
        public List<string> AminoAcidsPrevTags { get; set; }

        [JsonPropertyName("amino_acids_tags")]
        public List<string> AminoAcidsTags { get; set; }

        [JsonPropertyName("brands")]
        public string Brands { get; set; }

        [JsonPropertyName("brands_debug_tags")]
        public List<string> BrandsDebugTags { get; set; }

        [JsonPropertyName("brands_tags")]
        public List<string> BrandsTags { get; set; }

        [JsonPropertyName("carbon_footprint_percent_of_known_ingredients")]
        public string CarbonFootprintPercentOfKnownIngredients { get; set; }

        [JsonPropertyName("carbon_footprint_from_known_ingredients_debug")]
        public string CarbonFootprintFromKnownIngredientsDebug { get; set; }

        [JsonPropertyName("categories")]
        public string Categories { get; set; }

        [JsonPropertyName("categories_hierarchy")]
        public List<string> CategoriesHierarchy { get; set; }

        [JsonPropertyName("categories_lc")]
        public string CategoriesLc { get; set; }

        [JsonPropertyName("categories_properties_tags")]
        public List<string> CategoriesPropertiesTags { get; set; }

        [JsonPropertyName("categories_tags")]
        public List<string> CategoriesTags { get; set; }

        [JsonPropertyName("checkers_tags")]
        public List<string> CheckersTags { get; set; }

        [JsonPropertyName("cities_tags")]
        public List<string> CitiesTags { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("codes_tags")]
        public List<string> CodesTags { get; set; }

        [JsonPropertyName("compared_to_category")]
        public string ComparedToCategory { get; set; }

        [JsonPropertyName("complete")]
        public int Complete { get; set; }

        [JsonPropertyName("completed_t")]
        public long CompletedT { get; set; }

        [JsonPropertyName("completeness")]
        public float Completeness { get; set; }

        [JsonPropertyName("conservation_conditions")]
        public string ConservationConditions { get; set; }

        [JsonPropertyName("countries")]
        public string Countries { get; set; }

        [JsonPropertyName("countries_hierarchy")]
        public List<string> CountriesHierarchy { get; set; }

        [JsonPropertyName("countries_lc")]
        public string CountriesLc { get; set; }

        [JsonPropertyName("countries_debug_tags")]
        public List<string> CountriesDebugTags { get; set; }

        [JsonPropertyName("countries_tags")]
        public List<string> CountriesTags { get; set; }

        [JsonPropertyName("correctors_tags")]
        public List<string> correctorsTags { get; set; }

        [JsonPropertyName("created_t")]
        public long CreatedT { get; set; }

        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        [JsonPropertyName("data_quality_bugs_tags")]
        public List<string> DataQualityBugsTags { get; set; }

        [JsonPropertyName("data_quality_errors_tags")]
        public List<string> DataQualityErrorsTags { get; set; }

        [JsonPropertyName("data_quality_info_tags")]
        public List<string> DataQualityInfoTags { get; set; }

        [JsonPropertyName("data_quality_tags")]
        public List<string> DataQualityTags { get; set; }

        [JsonPropertyName("data_quality_warnings_tags")]
        public List<string> DataQualityWarningsTags { get; set; }

        [JsonPropertyName("data_sources")]
        public string DataSources { get; set; }

        [JsonPropertyName("data_sources_tags")]
        public List<string> DataSourcesTags { get; set; }

        [JsonPropertyName("debug_param_sorted_langs")]
        public List<string> DebugParamSortedLangs { get; set; }

        [JsonPropertyName("editors_tags")]
        public List<string> EditorsTags { get; set; }

        [JsonPropertyName("emb_codes")]
        public string EmbCodes { get; set; }

        [JsonPropertyName("emb_codes_debug_tags")]
        public List<string> EmbCodesDebugTags { get; set; }

        [JsonPropertyName("emb_codes_orig")]
        public string EmbCodesOrig { get; set; }

        [JsonPropertyName("emb_codes_tags")]
        public List<string> EmbCodesTags { get; set; }

        [JsonPropertyName("entry_dates_tags")]
        public List<string> EntryDatesTags { get; set; }

        [JsonPropertyName("expiration_date")]
        public string ExpirationDate { get; set; }

        [JsonPropertyName("expiration_date_debug_tags")]
        public List<string> ExpirationDateDebugTags { get; set; }

        [JsonPropertyName("fruits-vegetables-nuts_100g_estimate")]
        public int FruitsVegetablesNuts100GEstimate { get; set; }

        [JsonPropertyName("generic_name")]
        public string GenericName { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("_id")]
        public string OtherId { get; set; }

        [JsonPropertyName("image_front_small_url")]
        public string ImageFrontSmallUrl { get; set; }

        [JsonPropertyName("image_front_thumb_url")]
        public string ImageFrontThumbUrl { get; set; }

        [JsonPropertyName("image_front_url")]
        public string ImageFrontUrl { get; set; }

        [JsonPropertyName("image_ingredients_url")]
        public string ImageIngredientsUrl { get; set; }

        [JsonPropertyName("image_ingredients_small_url")]
        public string ImageIngredientsSmallUrl { get; set; }

        [JsonPropertyName("image_ingredients_thumb_url")]
        public string ImageIngredientsThumbUrl { get; set; }

        [JsonPropertyName("image_nutrition_small_url")]
        public string ImageNutritionSmallUrl { get; set; }

        [JsonPropertyName("image_nutrition_thumb_url")]
        public string ImageNutritionThumbUrl { get; set; }

        [JsonPropertyName("image_nutrition_url")]
        public string ImageNutritionUrl { get; set; }

        [JsonPropertyName("image_small_url")]
        public string ImageSmallUrl { get; set; }

        [JsonPropertyName("image_thumb_url")]
        public string ImageThumbUrl { get; set; }

        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("informers_tags")]
        public List<string> InformersTags { get; set; }

        [JsonPropertyName("ingredients_analysis_tags")]
        public List<string> IngredientsAnalysisTags { get; set; }

        [JsonPropertyName("ingredients_debug")]
        public List<string> IngredientsDebug { get; set; }

        [JsonPropertyName("ingredients_from_or_that_may_be_from_palm_oil_n")]
        public int IngredientsFromOrThatMayBeFromPalmOilN { get; set; }

        [JsonPropertyName("ingredients_from_palm_oil_tags")]
        public List<string> IngredientsFromPalmOilTags { get; set; }

        [JsonPropertyName("ingredients_from_palm_oil_n")]
        public int IngredientsFromPalmOilN { get; set; }

        [JsonPropertyName("ingredients_hierarchy")]
        public List<string> IngredientsHierarchy { get; set; }

        [JsonPropertyName("ingredients_ids_debug")]
        public List<string> IngredientsIdsDebug { get; set; }

        [JsonPropertyName("ingredients_n")]
        public int IngredientsN { get; set; }

        [JsonPropertyName("ingredients_n_tags")]
        public List<string> IngredientsNTags { get; set; }

        [JsonPropertyName("ingredients_original_tags")]
        public List<string> IngredientsOriginalTags { get; set; }

        [JsonPropertyName("ingredients_tags")]
        public List<string> IngredientsTags { get; set; }

        [JsonPropertyName("ingredients_text")]
        public string IngredientsText { get; set; }

        [JsonPropertyName("ingredients_text_debug")]
        public string IngredientsTextDebug { get; set; }

        [JsonPropertyName("ingredients_text_with_allergens")]
        public string IngredientsTextWithAllergens { get; set; }

        [JsonPropertyName("ingredients_that_may_be_from_palm_oil_n")]
        public int IngredientsThatMayBeFromPalmOilN { get; set; }

        [JsonPropertyName("ingredients_that_may_be_from_palm_oil_tags")]
        public List<string> IngredientsThatMayBeFromPalmOilTags { get; set; }

        [JsonPropertyName("interface_version_created")]
        public string InterfaceVersionCreated { get; set; }

        [JsonPropertyName("interface_version_modified")]
        public string InterfaceVersionModified { get; set; }

        [JsonPropertyName("_keywords")]
        public List<string> Keywords { get; set; }

        [JsonPropertyName("known_ingredients_n")]
        public int KnownIngredientsN { get; set; }

        [JsonPropertyName("labels")]
        public string Labels { get; set; }

        [JsonPropertyName("labels_hierarchy")]
        public List<string> labelsHierarchy { get; set; }

        [JsonPropertyName("labels_lc")]
        public string LabelsLc { get; set; }

        [JsonPropertyName("labels_prev_hierarchy")]
        public List<string> LabelsPrevHierarchy { get; set; }

        [JsonPropertyName("labels_prev_tags")]
        public List<string> labelsPrevTags { get; set; }

        [JsonPropertyName("labels_tags")]
        public List<string> LabelsTags { get; set; }

        [JsonPropertyName("labels_debug_tags")]
        public List<string> LabelsDebugTags { get; set; }

        [JsonPropertyName("lang")]
        public string Lang { get; set; }

        [JsonPropertyName("lang_debug_tags")]
        public List<string> LangDebugTags { get; set; }

        [JsonPropertyName("languages_hierarchy")]
        public List<string> LanguagesHierarchy { get; set; }

        [JsonPropertyName("languages_tags")]
        public List<string> LanguagesTags { get; set; }

        [JsonPropertyName("last_edit_dates_tags")]
        public List<string> LastEditDatesTags { get; set; }

        [JsonPropertyName("last_editor")]
        public string LastEditor { get; set; }

        [JsonPropertyName("last_image_dates_tags")]
        public List<string> LastImageDatesTags { get; set; }

        [JsonPropertyName("last_image_t")]
        public long LastImageT { get; set; }

        [JsonPropertyName("last_modified_by")]
        public string LastModifiedBy { get; set; }

        [JsonPropertyName("last_modified_t")]
        public long LastModifiedT { get; set; }

        [JsonPropertyName("lc")]
        public string LC { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("link_debug_tags")]
        public List<string> LinkDebugTags { get; set; }

        [JsonPropertyName("manufacturing_places")]
        public string ManufacturingPlaces { get; set; }

        [JsonPropertyName("manufacturing_places_debug_tags")]
        public List<string> ManufacturingPlacesDebugTags { get; set; }

        [JsonPropertyName("manufacturing_places_tags")]
        public List<string> ManufacturingPlacesTags { get; set; }

        [JsonPropertyName("max_imgid")]
        public string MaxImgid { get; set; }

        [JsonPropertyName("minerals_prev_tags")]
        public List<string> MineralsPrevTags { get; set; }

        [JsonPropertyName("minerals_tags")]
        public List<string> MineralsTags { get; set; }

        [JsonPropertyName("misc_tags")]
        public List<string> MiscTags { get; set; }

        [JsonPropertyName("net_weight_unit")]
        public string NetWeightUnit { get; set; }

        [JsonPropertyName("net_weight_value")]
        public string NetWeightValue { get; set; }

        [JsonPropertyName("nutrition_data_per")]
        public string NutritionDataPer { get; set; }

        [JsonPropertyName("nutrition_score_warning_no_fruits_vegetables_nuts")]
        public int NutritionScoreWarningNoFruitsVegetablesNuts { get; set; }

        [JsonPropertyName("no_nutrition_data")]
        public string NoNutritionData { get; set; }

        [JsonPropertyName("nova_group")]
        public string NovaGroup { get; set; }

        [JsonPropertyName("nova_groups")]
        public string NovaGroups { get; set; }

        [JsonPropertyName("nova_group_debug")]
        public string NovaGroupDebug { get; set; }

        [JsonPropertyName("nova_group_tags")]
        public List<string> NovaGroupTags { get; set; }

        [JsonPropertyName("nova_groups_tags")]
        public List<string> NovaGroupsTags { get; set; }

        [JsonPropertyName("nucleotides_prev_tags")]
        public List<string> NucleotidesPrevTags { get; set; }

        [JsonPropertyName("nucleotides_tags")]
        public List<string> NucleotidesTags { get; set; }

        [JsonPropertyName("nutrient_levels_tags")]
        public List<string> NutrientLevelsTags { get; set; }

        [JsonPropertyName("nutrition_data")]
        public string NutritionData { get; set; }

        [JsonPropertyName("nutrition_data_per_debug_tags")]
        public List<string> NutritionDataPerDebugTags { get; set; }

        [JsonPropertyName("nutrition_data_prepared")]
        public string NutritionDataPrepared { get; set; }

        [JsonPropertyName("nutrition_data_prepared_per")]
        public string NutritionDataPreparedPer { get; set; }

        [JsonPropertyName("nutrition_grades")]
        public string NutritionGrades { get; set; }

        [JsonPropertyName("nutrition_score_beverage")]
        public int NutritionScoreBeverage { get; set; }

        [JsonPropertyName("nutrition_score_debug")]
        public string NutritionScoreDebug { get; set; }

        [JsonPropertyName("nutrition_score_warning_no_fiber")]
        public int NutritionScoreWarningNoFiber { get; set; }

        [JsonPropertyName("nutrition_grades_tags")]
        public List<string> NutritionGradesTags { get; set; }

        [JsonPropertyName("origins")]
        public string Origins { get; set; }

        [JsonPropertyName("origins_debug_tags")]
        public List<string> OriginsDebugTags { get; set; }

        [JsonPropertyName("origins_tags")]
        public List<string> OriginsTags { get; set; }

        [JsonPropertyName("other_information")]
        public string OtherInformation { get; set; }

        [JsonPropertyName("other_nutritional_substances_tags")]
        public List<string> OtherNutritionalSubstancesTags { get; set; }

        [JsonPropertyName("packaging")]
        public string Packaging { get; set; }

        [JsonPropertyName("packaging_debug_tags")]
        public List<string> PackagingDebugTags { get; set; }

        [JsonPropertyName("packaging_tags")]
        public List<string> PackagingTags { get; set; }

        [JsonPropertyName("photographers_tags")]
        public List<string> PhotographersTags { get; set; }

        [JsonPropertyName("pnns_groups_1")]
        public string PnnsGroups1 { get; set; }

        [JsonPropertyName("pnns_groups_2")]
        public string PnnsGroups2 { get; set; }

        [JsonPropertyName("pnns_groups_1_tags")]
        public List<string> PnnsGroups1Tags { get; set; }

        [JsonPropertyName("pnns_groups_2_tags")]
        public List<string> PnnsGroups2Tags { get; set; }

        [JsonPropertyName("popularity_key")]
        public long PopularityKey { get; set; }

        [JsonPropertyName("producer_version_id")]
        public string ProducerVersionId { get; set; }

        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        [JsonPropertyName("product_quantity")]
        public string ProductQuantity { get; set; }

        [JsonPropertyName("purchase_places")]
        public string PurchasePlaces { get; set; }

        [JsonPropertyName("purchase_places_debug_tags")]
        public List<string> PurchasePlacesDebugTags { get; set; }

        [JsonPropertyName("purchase_places_tags")]
        public List<string> PurchasePlacesTags { get; set; }

        [JsonPropertyName("quality_tags")]
        public List<string> QualityTags { get; set; }

        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        [JsonPropertyName("quantity_debug_tags")]
        public List<string> QuantityDebugTags { get; set; }

        [JsonPropertyName("recycling_instructions_to_discard")]
        public string RecyclingInstructionsToDiscard { get; set; }

        [JsonPropertyName("rev")]
        public int Rev { get; set; }

        [JsonPropertyName("serving_quantity")]
        public string ServingQuantity { get; set; }

        [JsonPropertyName("serving_size")]
        public string ServingSize { get; set; }

        [JsonPropertyName("serving_size_debug_tags")]
        public List<string> ServingSizeDebugTags { get; set; }

        [JsonPropertyName("sortkey")]
        public long Sortkey { get; set; }

        [JsonPropertyName("states")]
        public string States { get; set; }

        [JsonPropertyName("states_hierarchy")]
        public List<string> StatesHierarchy { get; set; }

        [JsonPropertyName("states_tags")]
        public List<string> StatesTags { get; set; }

        [JsonPropertyName("stores")]
        public string Stores { get; set; }

        [JsonPropertyName("stores_debug_tags")]
        public List<string> StoresDebugTags { get; set; }

        [JsonPropertyName("stores_tags")]
        public List<string> StoresTags { get; set; }

        [JsonPropertyName("traces")]
        public string Traces { get; set; }

        [JsonPropertyName("traces_from_ingredients")]
        public string TracesFromIngredients { get; set; }

        [JsonPropertyName("traces_hierarchy")]
        public List<string> TracesHierarchy { get; set; }

        [JsonPropertyName("traces_debug_tags")]
        public List<string> TracesDebugTags { get; set; }

        [JsonPropertyName("traces_from_user")]
        public string TracesFromUser { get; set; }

        [JsonPropertyName("traces_lc")]
        public string TracesLc { get; set; }

        [JsonPropertyName("traces_tags")]
        public List<string> TracesTags { get; set; }

        [JsonPropertyName("unknown_ingredients_n")]
        public int UnknownIngredientsN { get; set; }

        [JsonPropertyName("unknown_nutrients_tags")]
        public List<string> UnknownNutrientsTags { get; set; }

        [JsonPropertyName("update_key")]
        public string UpdateKey { get; set; }

        [JsonPropertyName("vitamins_prev_tags")]
        public List<string> VitaminsPrevTags { get; set; }

        [JsonPropertyName("vitamins_tags")]
        public List<string> VitaminsTags { get; set; }
    }
}
