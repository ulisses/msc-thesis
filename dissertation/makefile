UNAME=$(shell uname -s)
REL=dissertation
PDF=$(REL).pdf
TEX=$(REL).tex
TEXS=$(shell find . -iname "*.tex")

all:$(PDF)

# Compile the PDF file
$(PDF):$(TEXS)
ifeq ($(UNAME),Darwin)
	latexmk -e '$$pdflatex=q/pdflatex --shell-escape -synctex=1 %T/' -pdf $(TEX)
endif
ifeq ($(UNAME),Linux)
	latexmk -pdf $(TEX)
endif

# open PDF file
open:
	make $(PDF)
ifeq ($(UNAME),Darwin)
	open $(PDF)
endif
ifeq ($(UNAME),Linux)
	evince $(PDF)
endif

# Clean rules
clean:
	@echo "Cleaning the shop"
	@find . -maxdepth 1 \( \! -iname \.latexmkrc \! -iname README* \! -iname .gitignore \! -iname "*.bib" \! -iname "*.tex" -type f \! -iname "makefile" \! -iname "*.sty" \! -iname "*.cls" \) -exec rm -f '{}' \;
	@find . \( -name *~ -or -name *.*~ \) -exec rm -f '{}' \;

