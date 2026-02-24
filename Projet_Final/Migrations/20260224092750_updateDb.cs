using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projet_Final.Migrations
{
    /// <inheritdoc />
    public partial class updateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecettesIngredients_Ingredients_Id_Ingredient",
                table: "RecettesIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecettesIngredients_Recettes_Id_Recette",
                table: "RecettesIngredients");

            migrationBuilder.RenameColumn(
                name: "Id_Recette",
                table: "RecettesIngredients",
                newName: "RecetteId");

            migrationBuilder.RenameColumn(
                name: "Id_Ingredient",
                table: "RecettesIngredients",
                newName: "IngredientId");

            migrationBuilder.RenameIndex(
                name: "IX_RecettesIngredients_Id_Recette",
                table: "RecettesIngredients",
                newName: "IX_RecettesIngredients_RecetteId");

            migrationBuilder.RenameIndex(
                name: "IX_RecettesIngredients_Id_Ingredient",
                table: "RecettesIngredients",
                newName: "IX_RecettesIngredients_IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecettesIngredients_Ingredients_IngredientId",
                table: "RecettesIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecettesIngredients_Recettes_RecetteId",
                table: "RecettesIngredients",
                column: "RecetteId",
                principalTable: "Recettes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecettesIngredients_Ingredients_IngredientId",
                table: "RecettesIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_RecettesIngredients_Recettes_RecetteId",
                table: "RecettesIngredients");

            migrationBuilder.RenameColumn(
                name: "RecetteId",
                table: "RecettesIngredients",
                newName: "Id_Recette");

            migrationBuilder.RenameColumn(
                name: "IngredientId",
                table: "RecettesIngredients",
                newName: "Id_Ingredient");

            migrationBuilder.RenameIndex(
                name: "IX_RecettesIngredients_RecetteId",
                table: "RecettesIngredients",
                newName: "IX_RecettesIngredients_Id_Recette");

            migrationBuilder.RenameIndex(
                name: "IX_RecettesIngredients_IngredientId",
                table: "RecettesIngredients",
                newName: "IX_RecettesIngredients_Id_Ingredient");

            migrationBuilder.AddForeignKey(
                name: "FK_RecettesIngredients_Ingredients_Id_Ingredient",
                table: "RecettesIngredients",
                column: "Id_Ingredient",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecettesIngredients_Recettes_Id_Recette",
                table: "RecettesIngredients",
                column: "Id_Recette",
                principalTable: "Recettes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
