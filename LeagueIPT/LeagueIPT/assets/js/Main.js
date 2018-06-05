document.addEventListener("DOMContentLoaded",
    function main() {
        function init() {
            load();
            //ecrachamps();
        }

        init();

        var loading;
        function load() {
            loading = setTimeout(ecrachamps, 300);

        }

        /**
         *
         *
         * @param {Array<{ id: string, Pic: string }>} champs
         */
        function mostrarChamps(champs) {

            for (let champ of champs) {
                const mainDiv = document.querySelector("#conteudo");
                const a = document.createElement("a");
                a.setAttribute("style",
                    "height: 80px; margin-bottom:25px; margin-left:12px;margin-right:12px;width:80px;");
                const img = document.createElement("img");
                img.setAttribute("style", "width:80px");
                img.setAttribute("src", champ.Pic);
                img.setAttribute("title", champ.Name);
                img.addEventListener("click",
                    function() {
                        getDetalhes(champ.ID).then(function (result) {
                            const emptyDiv = document.querySelector("#champion");
                                emptyDiv.classList.add("hide");
                                detalhes(result);
                            })
                            .catch(function(erro) {
                                console.error(erro);
                                alert("Lamentamos, mas ocorreu um erro...");

                            });
                    });

                a.appendChild(img);
                mainDiv.appendChild(a);
            }
        }

        function detalhes(champion) {
            console.log("Champion!", champion);
            const divPrincipal = document.querySelector("#main");
            //criar um div class container
            const divContainer = document.createElement("div");
            divContainer.setAttribute("class","container");
            divPrincipal.appendChild(divContainer);

            //criar um div para meter dentro do container com a class Jumbotron
            const divJumb = document.createElement("div");
            divJumb.setAttribute("class", "jumbotron");
            divJumb.setAttribute("style", "background-color:rgba(0,0,0,0.15); padding-top: 25px; margin-top:5%; padding-bottom:32px;");

            divContainer.appendChild(divJumb);

            //Nome do champion
            const champName = document.createElement("h1");
            champName.setAttribute("class","text-center");
            champName.setAttribute("style","color:rgba(255,255,255,0.7);");
            champName.textContent = champion.Nome;
            divJumb.appendChild(champName);

            //Nickname do Champion
            const champNick = document.createElement("p");
            champNick.setAttribute("class","text-center");
            champNick.setAttribute("style","color:rgba(255,255,255,0.7);");
            champNick.textContent = champion.Nick;
            divJumb.appendChild(champNick);

            //div da class card
            const divCard = document.createElement("div");
            divCard.setAttribute("class", "card");
            divJumb.appendChild(divCard);

            //card header
            const divCardHeader = document.createElement("div");
            divCardHeader.setAttribute("class", "card-header");
            divCardHeader.setAttribute("style", "background-color:rgba(147,147,147,0.55);");
            divCard.appendChild(divCardHeader);

            //ul para fazer as tabs
            const divUl = document.createElement("ul");
            divUl.setAttribute("class", "nav nav-tabs card-header-tabs");
            divUl.setAttribute("role", "tablist");
            divCardHeader.appendChild(divUl);

            //primeira tab
            const divLi1 = document.createElement("li");
            divLi1.setAttribute("class", "nav-item");
            divUl.appendChild(divLi1);

            //O que tem na class "active será o que aparece por default"
            const divA = document.createElement("a");
            divA.setAttribute("class", "nav-link active");
            divA.setAttribute("href", "#item-1-1");
            divA.setAttribute("id", "item-1-1-tab");
            divA.setAttribute("data-toggle", "tab");
            divA.setAttribute("role", "tab");
            divA.setAttribute("aria-controls", "item-1-1");
            divA.setAttribute("aria-selected", "true");
            divA.textContent = "About";
            divLi1.appendChild(divA);

            //segunda tab
            const divLi2 = document.createElement("li");
            divLi2.setAttribute("class", "nav-item");
            divUl.appendChild(divLi2);

            const divA1 = document.createElement("a");
            divA1.setAttribute("class", "nav-link");
            divA1.setAttribute("href", "#item-1-2");
            divA1.setAttribute("id", "item-1-2-tab");
            divA1.setAttribute("data-toggle", "tab");
            divA1.setAttribute("role", "tab");
            divA1.setAttribute("aria-controls", "item-1-2");
            divA1.setAttribute("aria-selected", "false");
            divA1.textContent = "Attributes";
            divLi2.appendChild(divA1);

            //terceira tab
            const divLi3 = document.createElement("li");
            divLi2.setAttribute("class", "nav-item");
            divUl.appendChild(divLi3);

            const divA2 = document.createElement("a");
            divA2.setAttribute("class", "nav-link");
            divA2.setAttribute("href", "#item-1-3");
            divA2.setAttribute("id", "item-1-3-tab");
            divA2.setAttribute("data-toggle", "tab");
            divA2.setAttribute("role", "tab");
            divA2.setAttribute("aria-controls", "item-1-3");
            divA2.setAttribute("aria-selected", "false");
            divA2.textContent = "Skins";
            divLi3.appendChild(divA2);

            //body do card
            const divCardBody = document.createElement("div");
            divCardBody.setAttribute("class", "card-body");
            divCardBody.setAttribute("style", "background-color:rgba(235,235,235,0.45);");
            divCard.appendChild(divCardBody);

            const tabContent = document.createElement("div");
            tabContent.setAttribute("class", "tab-content");
            tabContent.setAttribute("id", "nav-tabContent");
            divCardBody.appendChild(tabContent);

            //show active é o tab que estara em default
            const tabConteudo = document.createElement("div");
            tabConteudo.setAttribute("class", "tab-pane fade show active");
            tabConteudo.setAttribute("id", "item-1-1");
            tabConteudo.setAttribute("role", "tabpanel");
            tabConteudo.setAttribute("aria-labelledby", "item-1-1-tab");

            //descrição do champ
            const tabTit = document.createElement("h4");
            tabTit.textContent = "Description";

            const tabDesc = document.createElement("p");
            tabDesc.textContent = champion.Descricao;

            tabContent.appendChild(tabConteudo);
            tabConteudo.appendChild(tabTit);
            tabConteudo.appendChild(tabDesc);

            const br = document.createElement("br");
            tabDesc.appendChild(br);

            //imagem principal
            //const img = document.createElement("img");
            const imgDiv = document.createElement("div");
            //img.setAttribute("src", champion.Imagem);
            //img.setAttribute("style", "width:100%; background-position:top;background-size:cover;background-repeat:no-repeat;height:350px;");
            //meti o cod de cima numa class mas nem isso resultou.
            //img.setAttribute("class", "imagem");
            imgDiv.setAttribute("style", `${`background-image:url("${champion.Imagem}");`} width:100%; background-position:top;background-size:cover;background-repeat:no-repeat;height:375px`);
            tabConteudo.appendChild(imgDiv);

            //tab numero 2. Este ira ter mais informações sobre o champ
            const tabConteudo2 = document.createElement("div");
            tabConteudo2.setAttribute("class", "tab-pane fade");
            tabConteudo2.setAttribute("id", "item-1-2");
            tabConteudo2.setAttribute("role", "tabpanel");
            tabConteudo2.setAttribute("aria-labelledby", "item-1-2-tab");
            tabContent.appendChild(tabConteudo2);

            //criar uma row para adicionar colunas
            const divRow = document.createElement("div");
            divRow.setAttribute("class","row");
            divRow.setAttribute("style", "padding-top:20px;");
            tabConteudo2.appendChild(divRow);

            //coluna 1
            const divCol = document.createElement("div");
            divCol.setAttribute("class", "col-md-4 col-lg-2 offset-0 align-self-center");
            divCol.setAttribute("style", "padding-right:0px;padding-left:0px;");
            divRow.appendChild(divCol);

            const colType = document.createElement("h4");
            colType.setAttribute("class", "text-center");
            colType.textContent = "Type";
            divCol.appendChild(colType);

            const typeImg = document.createElement("h4");
            typeImg.setAttribute("class", "text-center");
            divCol.appendChild(typeImg);

            const imgType = document.createElement("img");
            imgType.setAttribute("src", champion.Job);
            imgType.setAttribute("width", "101px");
            typeImg.appendChild(imgType);

            const colRole = document.createElement("h4");
            colRole.setAttribute("class", "text-center");
            colRole.textContent = "Role";
            divCol.appendChild(colRole);

            const roleImg = document.createElement("h4");
            roleImg.setAttribute("class", "text-center");
            divCol.appendChild(roleImg);

            const imgRole = document.createElement("img");
            imgRole.setAttribute("src", champion.Lane);
            roleImg.appendChild(imgRole);

            //coluna 2
            const divCol2 = document.createElement("div");
            divCol2.setAttribute("class", "col-md-4 col-lg-4");
            divCol2.setAttribute("style", "padding-right:0px;padding-left:0px;");
            divRow.appendChild(divCol2);

            const spam = document.createElement("spam");
            spam.setAttribute("class", "counter pull-right");
            divCol2.appendChild(spam);

            const table = document.createElement("table");
            table.setAttribute("class", "table table-hover table-bordered results");
            divCol2.appendChild(table);

            const tbody = document.createElement("tbody");
            table.appendChild(tbody);

            //cell 1
            const tr = document.createElement("tr");
            tbody.appendChild(tr);

            const th = document.createElement("th");
            th.setAttribute("scope", "row");
            th.textContent = "Style";
            tr.appendChild(th);

            const td = document.createElement("td");
            td.textContent = champion.Atributo;
            tr.appendChild(td);

            //cel 2
            const tr1 = document.createElement("tr");
            tbody.appendChild(tr1);

            const th1 = document.createElement("th");
            th1.setAttribute("scope", "row");
            th1.textContent = "Range";
            tr1.appendChild(th1);

            const td1 = document.createElement("td");
            td1.textContent = champion.Range;
            tr1.appendChild(td1);

            //cel 3
            const tr2 = document.createElement("tr");
            tbody.appendChild(tr2);

            const th2 = document.createElement("th");
            th2.setAttribute("scope", "row");
            th2.textContent = "Health";
            tr2.appendChild(th2);

            const td2 = document.createElement("td");
            td2.textContent = champion.Health;
            tr2.appendChild(td2);

           //cel 4
            const tr3 = document.createElement("tr");
            tbody.appendChild(tr3);

            const th3 = document.createElement("th");
            th3.setAttribute("scope", "row");
            th3.textContent = "Attack Damage";
            tr3.appendChild(th3);

            const td3 = document.createElement("td");
            td3.textContent = champion.AttackDamage;
            tr3.appendChild(td3);

            //cel 5
            const tr4 = document.createElement("tr");
            tbody.appendChild(tr4);

            const th4 = document.createElement("th");
            th4.setAttribute("scope", "row");
            th4.textContent = "Attack Speed";
            tr4.appendChild(th4);

            const td4 = document.createElement("td");
            td4.textContent = champion.AttackSpeed;
            tr4.appendChild(td4);

            //cel 6
            const tr5 = document.createElement("tr");
            tbody.appendChild(tr5);

            const th5 = document.createElement("th");
            th5.setAttribute("scope", "row");
            th5.textContent = "Move Speed";
            tr5.appendChild(th5);

            const td5 = document.createElement("td");
            td5.textContent = champion.MovSpeed;
            tr5.appendChild(td5);

            //cel 7
            const tr6 = document.createElement("tr");
            tbody.appendChild(tr6);

            const th6 = document.createElement("th");
            th6.setAttribute("scope", "row");
            th6.textContent = "Type";
            tr6.appendChild(th6);

            const td6 = document.createElement("td");
            td6.textContent = champion.Role;
            tr6.appendChild(td6);

            //cel 8
            const tr7 = document.createElement("tr");
            tbody.appendChild(tr7);

            const th7 = document.createElement("th");
            th7.setAttribute("scope", "row");
            th7.textContent = "Release Date";
            tr7.appendChild(th7);

            const td7 = document.createElement("td");
            td7.textContent = champion.ReleaseDate;
            tr7.appendChild(td7);

            //coluna 3
            const divCol3 = document.createElement("div");
            divCol3.setAttribute("class", "col-md-4 col-lg-6");
            const divTit = document.createElement("h4");
            divTit.setAttribute("class","text-center");
            divTit.setAttribute("style", "padding-bottom:13px;");
            divTit.textContent = "Abilities";
            divRow.appendChild(divCol3);
            divCol3.appendChild(divTit);
       
            const spam1 = document.createElement("spam");
            spam1.setAttribute("class", "counter pull-right");
            divCol3.appendChild(spam1);

            const table1 = document.createElement("table");
            table1.setAttribute("class", "table table-hover table-bordered results");
            divCol3.appendChild(table1);

            const tbody1 = document.createElement("tbody");
            table1.appendChild(tbody1);


            //cell 1
            const tr11 = document.createElement("tr");
            tbody1.appendChild(tr11);
            const th11 = document.createElement("th");
            th11.setAttribute("scope", "row");
            th11.textContent = "Passive";
            tr11.appendChild(th11);
            const td11 = document.createElement("td");
            td11.textContent = champion.LHabilidades[0].Passiva;
            tr11.appendChild(td11);

            //cell 2
            const tr22 = document.createElement("tr");
            tbody1.appendChild(tr22);
            const th22 = document.createElement("th");
            th22.setAttribute("scope", "row");
            th22.textContent = "Q";
            tr22.appendChild(th22);
            const td22 = document.createElement("td");
            td22.textContent = champion.LHabilidades[0].Q;
            tr22.appendChild(td22);

            //cell 3
            const tr33 = document.createElement("tr");
            tbody1.appendChild(tr33);
            const th33 = document.createElement("th");
            th33.setAttribute("scope", "row");
            th33.textContent = "W";
            tr33.appendChild(th33);
            const td33 = document.createElement("td");
            td33.textContent = champion.LHabilidades[0].W;
            tr33.appendChild(td33);

            //cell 5
            const tr44 = document.createElement("tr");
            tbody1.appendChild(tr44);
            const th44 = document.createElement("th");
            th44.setAttribute("scope", "row");
            th44.textContent = "E";
            tr44.appendChild(th44);
            const td44 = document.createElement("td");
            td44.textContent = champion.LHabilidades[0].E;
            tr44.appendChild(td44);

            //cell 6
            const tr55 = document.createElement("tr");
            tbody1.appendChild(tr55);
            const th55 = document.createElement("th");
            th55.setAttribute("scope", "row");
            th55.textContent = "R";
            tr55.appendChild(th55);
            const td55 = document.createElement("td");
            td55.textContent = champion.LHabilidades[0].R;
            tr55.appendChild(td55);

            //tab numero 3. Skins
            const tabConteudo3 = document.createElement("div");
            tabConteudo3.setAttribute("class", "tab-pane fade");
            tabConteudo3.setAttribute("id", "item-1-3");
            tabConteudo3.setAttribute("role", "tabpanel");
            tabConteudo3.setAttribute("aria-labelledby", "item-1-3-tab");
            tabContent.appendChild(tabConteudo3);
            
            const sliderDiv = document.createElement("div");
            sliderDiv.setAttribute("id", "carousel-1");
            sliderDiv.setAttribute("class", "carousel slide");
            sliderDiv.setAttribute("data-ride", "carousel");
            tabConteudo3.appendChild(sliderDiv);

            const sliderContDiv = document.createElement("div");
            sliderContDiv.setAttribute("class", "carousel-inner");
            sliderContDiv.setAttribute("role", "listbox");
            sliderDiv.appendChild(sliderContDiv);

            //slides

            //primeiro slide (ativo)
            const sliderAtivo = document.createElement("div");
            sliderAtivo.setAttribute("class", "carousel-item active");
            sliderContDiv.appendChild(sliderAtivo);

            const imgSlider1 = document.createElement("img");
            imgSlider1.setAttribute("class","w-100 d-block");
            imgSlider1.setAttribute("alt","slide image");
            imgSlider1.setAttribute("src", champion.LSkins[0].Img1);
            sliderAtivo.appendChild(imgSlider1);

            //nome Skin
            const divNomeSkin = document.createElement("div");
            divNomeSkin.setAttribute("class","carousel-caption d-none d-md-block");
            sliderAtivo.appendChild(divNomeSkin);

            //nome
            const nomeskin1 = document.createElement("h5");
            nomeskin1.textContent = champion.LSkins[0].Nome1;
            divNomeSkin.appendChild(nomeskin1);

            //segundo slide

            const sliderNaoAtivo = document.createElement("div");
            sliderNaoAtivo.setAttribute("class", "carousel-item");
            sliderContDiv.appendChild(sliderNaoAtivo);

            const imgSlider2 = document.createElement("img");
            imgSlider2.setAttribute("class","w-100 d-block");
            imgSlider2.setAttribute("alt","slide image");
            imgSlider2.setAttribute("src", champion.LSkins[0].Img2);
            sliderNaoAtivo.appendChild(imgSlider2);

            //nome Skin
            const divNomeSkin1 = document.createElement("div");
            divNomeSkin1.setAttribute("class", "carousel-caption d-none d-md-block");
            sliderNaoAtivo.appendChild(divNomeSkin1);

            //nome
            const nomeskin2 = document.createElement("h5");
            nomeskin2.textContent = champion.LSkins[0].Nome2;
            divNomeSkin1.appendChild(nomeskin2);

            //comandos

            const emptyDiv = document.createElement("div");
            sliderDiv.appendChild(emptyDiv);

            //previous
            const aPrev = document.createElement("a");
            aPrev.setAttribute("class","carousel-control-prev");
            aPrev.setAttribute("href","#carousel-1");
            aPrev.setAttribute("role","button");
            aPrev.setAttribute("data-slide", "prev");
            emptyDiv.appendChild(aPrev);

            //next
            const aNext = document.createElement("a");
            aNext.setAttribute("class","carousel-control-next");
            aNext.setAttribute("href","#carousel-1");
            aNext.setAttribute("role","button");
            aNext.setAttribute("data-slide", "next");
            emptyDiv.appendChild(aNext);

        }

        async function ecrachamps() {
            try {
                const batatas = await getChamps();
                document.getElementById("loader").style.display = "none";
                mostrarChamps(batatas);
            } catch (erro) {
                console.error(erro);
            }
        }
    });