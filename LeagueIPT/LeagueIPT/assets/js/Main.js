document.addEventListener("DOMContentLoaded",
    function main() {
        function init() {
            ecrachamps();
        }

        init();

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
            const divContainer = document.createElement("div");
            divContainer.setAttribute("class","container");
            divPrincipal.appendChild(divContainer);

            const divJumb = document.createElement("div");
            divJumb.setAttribute("class", "jumbotron");
            divJumb.setAttribute("style", "background-color:rgba(0,0,0,0.15); padding-top: 25px; margin-top:5%; padding-bottom:32px;");

            divContainer.appendChild(divJumb);

            const champName = document.createElement("h1");
            champName.setAttribute("class","text-center");
            champName.setAttribute("style","color:rgba(255,255,255,0.7);");
            champName.textContent = champion.Nome;
            divJumb.appendChild(champName);

            const champNick = document.createElement("p");
            champNick.setAttribute("class","text-center");
            champNick.setAttribute("style","color:rgba(255,255,255,0.7);");
            champNick.textContent = champion.Nick;
            divJumb.appendChild(champNick);

            const divCard = document.createElement("div");
            divCard.setAttribute("class", "card");
            divJumb.appendChild(divCard);

            const divCardHeader = document.createElement("div");
            divCardHeader.setAttribute("class", "card-header");
            divCardHeader.setAttribute("style", "background-color:rgba(147,147,147,0.55);");
            divCard.appendChild(divCardHeader);

            const divUl = document.createElement("ul");
            divUl.setAttribute("class", "nav nav-tabs card-header-tabs");
            divUl.setAttribute("role", "tablist");
            divCardHeader.appendChild(divUl);

            const divLi1 = document.createElement("li");
            divLi1.setAttribute("class", "nav-item");
            divUl.appendChild(divLi1);

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
            divA2.textContent = "Media";
            divLi3.appendChild(divA2);

            const divCardBody = document.createElement("div");
            divCardBody.setAttribute("class", "card-body");
            divCardBody.setAttribute("style", "background-color:rgba(235,235,235,0.45);");
            divCard.appendChild(divCardBody);

            const tabContent = document.createElement("div");
            tabContent.setAttribute("class", "tab-content");
            tabContent.setAttribute("id", "nav-tabContent");
            divCardBody.appendChild(tabContent);

            const tabConteudo = document.createElement("div");
            tabConteudo.setAttribute("class", "tab-pane fade show active");
            tabConteudo.setAttribute("id", "item-1-1");
            tabConteudo.setAttribute("role", "tabpanel");
            tabConteudo.setAttribute("aria-labelledby", "item-1-1-tab");

            const tabTit = document.createElement("h4");
            tabTit.textContent = "Description";

            const tabDesc = document.createElement("p");
            tabDesc.textContent = champion.Descricao;

            tabContent.appendChild(tabConteudo);
            tabConteudo.appendChild(tabTit);
            tabConteudo.appendChild(tabDesc);

            const br = document.createElement("br");
            tabDesc.appendChild(br);

            const img = document.createElement("img");
            img.setAttribute("src", champion.Imagem);
            img.setAttribute("style", "width:100%; background-position:top;background-size:cover;background-repeat:no-repeat;height:300px;");
            //img.setAttribute("class", "imagem");
            //.setAttribute("style", `background-image:url(${ champion.Imagem })`);
            tabConteudo.appendChild(img);

        }

        async function ecrachamps() {
            try {
                const batatas = await getChamps();
                mostrarChamps(batatas);
            } catch (erro) {
                console.error(erro);
            }
        }
    });